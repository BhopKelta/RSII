using eBusStation.API.Models;
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

namespace eBusStation.Desktop
{
    public partial class NewBusInStation : Form
    {
        public NewBusInStation()
        {
            InitializeComponent();

            string[] busArray = new string[3];
            busArray[0] = "Mali";
            busArray[1] = "Veliki";
            busArray[2] = "Dvospratni";

            comboBoxBusTypes.DataSource = busArray; 
        }

        private void buttonAddBus_Click(object sender, EventArgs e)
        {
            if(textBoxBusSeats.Text=="" || textBoxManufacturer.Text=="" ||textBoxID.Text=="")
            {
                MessageBox.Show("Molimo unesiite obavezna polja");
                return;
            }

            int busSeats = 0,typeOfBusId=0;
            if(!Int32.TryParse(textBoxBusSeats.Text,out busSeats))
            {
                MessageBox.Show("Molimo unesite brojeve u polju");
                return;
            }
            if (comboBoxBusTypes.Text == "Dvospratni")
                typeOfBusId = 2;
            typeOfBusId = comboBoxBusTypes.Text == "Veliki" ? 1 : 2;
            Autobusi bus = new Autobusi
            {
                brojSjedistaBusa = Convert.ToInt32(textBoxBusSeats.Text),
                Proizvodjac = textBoxManufacturer.Text,
                RegOznake = textBoxID.Text,
                VrstaAutobusaId = typeOfBusId
            };
            HttpResponseMessage busResponse = HttpClientRequest.PostResult("/Bus/AddNewBus", bus);
            if (busResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Uspjesno dodan novi bus");
            }
        }
    }
}
