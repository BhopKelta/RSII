using eBusStation.API.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBusStation.API.Models;

namespace eBusStation.Desktop
{
    public partial class BusStoringImages : Form
    {
        public BusStoringImages()
        {
            InitializeComponent();
            HttpResponseMessage allBusesRequest = HttpClientRequest.GetResult("/Bus/AllBuses");
            if (allBusesRequest.IsSuccessStatusCode)
            {
                List<Get_All_Bus_Names_Result> buses = allBusesRequest.Content.ReadAsAsync<List<Get_All_Bus_Names_Result>>().Result;
                foreach (var bus in buses)
                {
                    comboBoxBuses.Items.Add(bus);
                }
                comboBoxBuses.DisplayMember = "Autobus";
                comboBoxBuses.ValueMember = "Id";
            }
            
        }
        public void BusStoringImages_Load(object sender,EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {

                string fileName = openFileDialog1.FileName;
                byte[] bytes = File.ReadAllBytes(fileName);

                int Id = comboBoxBuses.SelectedIndex;
                Autobusi bus = new Autobusi
                {
                    Id = Id,
                    slikaAutobusa = bytes
                };
                HttpResponseMessage response = HttpClientRequest.PostResult("/Bus/AddPicture", bus);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspjesno dodata slika");
                    this.Refresh();
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void comboBoxBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxBuses_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxBuses.Text))
            {
                MessageBox.Show("Molimo odaberite sliku autobusa");
                openFileDialog1.ShowDialog();
            }
        }
    }
}
