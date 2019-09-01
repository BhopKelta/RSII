using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using eBusStation.Desktop.Properties;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBusStation.API;
using eBusStation.API.Models;
using eBusStation.API.Static;

namespace eBusStation.Desktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                textBoxUserName.Text = Properties.Settings.Default.username;
                textBoxPw.Text = Properties.Settings.Default.password;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> queryParameters = new Dictionary<string, string>();
            queryParameters.Add("username", textBoxUserName.Text);
            queryParameters.Add("password", textBoxPw.Text);

            HttpResponseMessage response = HttpClientRequest.GetResult("/Login/Authenticate", queryParameters,Properties.Settings.Default.apiURL);

            if (string.IsNullOrEmpty(textBoxUserName.Text) || string.IsNullOrEmpty(textBoxPw.Text))
            {
                MessageBox.Show("Molimo unesite podatke za prijavu");
                return;
            }

            if (response.IsSuccessStatusCode)
            {
                Korisnici user = response.Content.ReadAsAsync<Korisnici>().Result;
                try
                {
                    if (user != null)
                    {
                        if (checkBoxRememberme.Checked)
                        {
                            Settings.Default.username = textBoxUserName.Text;
                            Settings.Default.password = textBoxPw.Text;
                            Settings.Default.uposlenikId = user.Id.ToString();
                            Settings.Default.Save();

                            MessageBox.Show(Settings.Default.username);
                        }
                        this.Hide();

                        MainForm main = new  MainForm();
                        main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Netacni podaci za prijavu");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }
    }
}
