using eBusStation.API.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBusStation.API.Models;
using eBusStation.Desktop.Properties;
using System.Text.RegularExpressions;
using eBusStation.API.JsonModels;

namespace eBusStation.Desktop
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Linije";
            comboBoxNotificationType.Text = "Obavijest";
            //Load data from the api - relations.
            HttpResponseMessage response = HttpClientRequest.GetResult("/Relation/Index",null, Properties.Settings.Default.apiURL);
            dataGridViewRelations.DataSource = response.Content.ReadAsAsync<List<usp_Get_All_Relations_Result>>().Result;
            dataGridViewRelations.Columns["Id"].Visible = false;
        }

        //On change type of notification, show particular input boxes.
        private void comboBoxNotificationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yCoordinateOfButton = buttonSaveNotification.Location.Y;

            if (comboBoxNotificationType.Text == "Obavijest")
            {
                textBoxDiscount.Hide();
                labelDiscount.Hide();
                textBoxDateExpiracy.Hide();
                labelDateExpiracy.Hide();

                buttonSaveNotification.Location = new Point(buttonSaveNotification.Location.X, yCoordinateOfButton - 80);
            }
            else if (comboBoxNotificationType.Text == "Popust")
            {
                textBoxDiscount.Show();
                labelDiscount.Show();
                textBoxDateExpiracy.Show();
                labelDateExpiracy.Show();

                buttonSaveNotification.Location = new Point(buttonSaveNotification.Location.X, yCoordinateOfButton + 80);

            }
        }

        private void buttonAddNotification_Click(object sender, EventArgs e)
        {
            comboBoxNotificationType.Text = "Obavijest";
            textBoxTextOfNotification.Text = "";
            textBoxDiscount.Text = "";
            textBoxDateExpiracy.Text = "";
        }

        private void dataGridViewRelations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxLineId.Text = dataGridViewRelations.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            dataGridViewRelations.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.YellowGreen;

            //To edit notification, show current text of notification
            if (Properties.Settings.Default.typeOfNotification == "N")
            {
                Properties.Settings.Default.infoOrDiscount = dataGridViewRelations.Rows[e.RowIndex].Cells["Tip"].Value.ToString();
                textBoxTextOfNotification.Text = dataGridViewRelations.Rows[e.RowIndex].Cells["Tekst"].Value.ToString();
            }
        }

        private void buttonSaveNotification_Click(object sender, EventArgs e)
        {
            string typeOfNotification = comboBoxNotificationType.Text;
            if (string.IsNullOrEmpty(textBoxTextOfNotification.Text))
            {
                MessageBox.Show("Molimo unesite napomenu obavijesti");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxLineId.Text))
            {
                MessageBox.Show("Molimo odaberite liniju za koju unosite obavijest");
                return;
            }
            if (typeOfNotification == "Obavijest")
            {
                //Add info notificaiton.
                Obavijesti notification = new Obavijesti
                {
                    LinijaId = Convert.ToInt32(textBoxLineId.Text),
                    Tekst = textBoxTextOfNotification.Text
                };
                HttpResponseMessage response = HttpClientRequest.PostResult("/Notification/AddInfo", notification);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Uspjesno dodana nova obavijest");
                else
                {
                    MessageBox.Show(response.ReasonPhrase);
                }
            }
            else if (typeOfNotification == "Popust")
            {
                Regex dateRegex = new Regex(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");
                Regex numberRegex = new Regex(@"^\d+$");
                if (string.IsNullOrEmpty(textBoxDateExpiracy.Text))
                { 
                    MessageBox.Show("Molimo unesite datum vazenja popusta");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxDiscount.Text))
                {
                    MessageBox.Show("Molimo unesite popust%");
                    return;
                }
                if (!dateRegex.IsMatch(textBoxDateExpiracy.Text))
                {
                    MessageBox.Show("Molimo unesite datum u ispravnom formatu dd-mm-yyyy ili sa /");
                    return;
                }
                if (!numberRegex.IsMatch(textBoxDiscount.Text))
                {
                    MessageBox.Show("Molimo unesite samo iznos popusta");
                    return;
                }
                decimal discountNumber = Convert.ToDecimal(textBoxDiscount.Text);
                Popusti discount = new Popusti
                {
                    Postotak = (float)discountNumber,
                    DatumVazenjaPopusta = Convert.ToDateTime(textBoxDateExpiracy.Text)
                };
                PopustNaLiniji discountOnLine = new PopustNaLiniji
                {
                    Popusti = discount,
                    LinijeId = Convert.ToInt32(textBoxLineId.Text),
                    Opis = textBoxTextOfNotification.Text
                };
                HttpResponseMessage response = HttpClientRequest.PostResult("/Discount/DiscountOnLine", discountOnLine);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Uspjesno dodana nova obavijest o popustu");
            }
        }

        private void buttonEditNotification_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.typeOfNotification == "N")
            {
                if (string.IsNullOrEmpty(textBoxLineId.Text))
                {
                    MessageBox.Show("Odaberite obavijest za izmjenu");
                    return;
                }
                EditNotificationModel model = new EditNotificationModel
                {
                    Id = textBoxLineId.Text,
                    notificationText = textBoxTextOfNotification.Text,
                    table = Properties.Settings.Default.infoOrDiscount
                };

                HttpResponseMessage response = HttpClientRequest.PostResult("/Notification/EditInfo", model);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspjesno izmjenjena obavijest");
                }
            }
        }

        private void buttonOpenNotification_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.typeOfNotification = "N";
            label2.Text = "Obavijesti";
            HttpResponseMessage response = HttpClientRequest.GetResult("/Notification/Index");
            if (response.IsSuccessStatusCode)
            {
                dataGridViewRelations.DataSource = response.Content.ReadAsAsync<List<usp_Get_All_Notifications_Result>>().Result;
            }
        }

        private void buttonOpenLines_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.typeOfNotification = "L";
            this.NotificationForm_Load(sender,e);
        }
    }
}
