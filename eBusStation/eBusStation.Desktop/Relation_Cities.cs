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
    public partial class Relation_Cities : Form
    {
        public Relation_Cities()
        {
            InitializeComponent();
        }

        private void Relation_Cities_Load(object sender, EventArgs e)
        {
            //Get all relations
            HttpResponseMessage response = HttpClientRequest.GetResult("/Relation/RelationWithTraveler");
            dataGridViewLines.DataSource = response.Content.ReadAsAsync<List<usp_Get_Lines_With_Traveler_Result>>().Result;
            dataGridViewLines.Columns["Id"].Visible = false;

            //Get all cities
            HttpResponseMessage cityResponse = HttpClientRequest.GetResult("/City/Index");
            comboBoxCities.DataSource = cityResponse.Content.ReadAsAsync<List<usp_Get_All_Cities_Result>>().Result;
            comboBoxCities.DisplayMember = "Naziv";
            comboBoxCities.ValueMember = "Id";
        }

        private void dataGridViewLines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("lineId", dataGridViewLines.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            HttpResponseMessage response = HttpClientRequest.GetResult("/Relation/lineId/Cities",query);
            dataGridViewCities.DataSource = response.Content.ReadAsAsync<List<usp_Get_Cities_That_Line_Passes_Result>>().Result;
            dataGridViewCities.Columns["Id"].Visible = false;
            textBoxLineId.Text = dataGridViewLines.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        }

        private void dataGridViewCities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Initialize textboxes with data of one city passed through line.
            textBoxCityLineId.Text = dataGridViewCities.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            comboBoxCities.Text = dataGridViewCities.Rows[e.RowIndex].Cells["Grad"].Value.ToString();
            comboBoxTypeOfCard.Text = dataGridViewCities.Rows[e.RowIndex].Cells["Tip_karte"].Value.ToString();
            textBoxPriceFromBegin.Text = dataGridViewCities.Rows[e.RowIndex].Cells["Cijena_od_polaska"].Value.ToString();
            textBoxPriceFromCurrent.Text = dataGridViewCities.Rows[e.RowIndex].Cells["Cijena_od_grada_destinacije"].Value.ToString();
            dateTimePickerTimeOfComing.Text = dataGridViewCities.Rows[e.RowIndex].Cells["Vrijeme_dolaska"].Value.ToString();
        }

        private void buttonAddCityToLine_Click(object sender, EventArgs e)
        {
            if (dataGridViewCities.DataSource != null)
            {
                //Add new visited city to line order passing.
                if (textBoxPriceFromBegin.Text == "")
                {
                    MessageBox.Show("Molimo unesite cijenu od polaska");
                    return;
                }
                if(textBoxPriceFromCurrent.Text=="")
                {
                    MessageBox.Show("Molimo unesite cijenu od trenutne stanice, ako samo unosite cijenu od polaska unesite 0 onda");
                    return;
                }
                PosjecujeLokacije cityPassingThrough = new PosjecujeLokacije();
                cityPassingThrough.isStudentska = comboBoxTypeOfCard.Text == "Obicna" ? false : true;
                cityPassingThrough.IsDeleted = false;
                cityPassingThrough.LinijeId = Convert.ToInt32(textBoxLineId.Text);
                double priceFromStartRoute = Convert.ToDouble(textBoxPriceFromBegin.Text);
                cityPassingThrough.cijenaOdPolaska = (float)priceFromStartRoute;
                double priceFromCurrentRoute = Convert.ToDouble(textBoxPriceFromCurrent.Text);
                cityPassingThrough.CijenaOdTrenutnogGradaDoDestinacije = priceFromCurrentRoute;
                cityPassingThrough.vrijemeDolaska = dateTimePickerTimeOfComing.Text;
                cityPassingThrough.GradId = (int)comboBoxCities.SelectedValue;

                HttpResponseMessage response = HttpClientRequest.PostResult("/Relation/AddCityPassingLine", cityPassingThrough);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Uspjesno dodan grad u redoslijedu voznje");
                this.Relation_Cities_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Odaberite liniju za koju zelite dodati grad kao dio redoslijeda voznje!Hvala");
                return;
            }
        }

        private void buttonUpdateCityInLine_Click(object sender, EventArgs e)
        {
            if (textBoxCityLineId.Text == "")
            {
                MessageBox.Show("Odaberite dio redoslijeda voznje za liniju koju zelite da promjenite");
                return;
            }
            PosjecujeLokacije cityPassingThrough = new PosjecujeLokacije();
            cityPassingThrough.Id = Convert.ToInt32(textBoxCityLineId.Text);

            cityPassingThrough.isStudentska = comboBoxTypeOfCard.Text == "Obicna" ? false : true;
            cityPassingThrough.IsDeleted = false;
            cityPassingThrough.LinijeId = Convert.ToInt32(textBoxLineId.Text);
            double priceFromStartRoute = Convert.ToDouble(textBoxPriceFromBegin.Text);
            cityPassingThrough.cijenaOdPolaska = (float)priceFromStartRoute;
            double priceFromCurrentRoute = Convert.ToDouble(textBoxPriceFromCurrent.Text);
            cityPassingThrough.CijenaOdTrenutnogGradaDoDestinacije = priceFromCurrentRoute;
            cityPassingThrough.vrijemeDolaska = dateTimePickerTimeOfComing.Text;
            cityPassingThrough.GradId = (int)comboBoxCities.SelectedValue;

            HttpResponseMessage response = HttpClientRequest.PostResult("/Relation/EditCityPassingLine", cityPassingThrough);
            if (response.IsSuccessStatusCode)
                MessageBox.Show("Uspjesno izmjenjen grad u redoslijedu voznje");
            this.Relation_Cities_Load(sender, e);
        }

        private void buttonRemoveLineOrder_Click(object sender, EventArgs e)
        {
            if (textBoxCityLineId.Text == "")
            {
                MessageBox.Show("Odaberite dio voznje u liniji koji zelite ukloniti");
                return;
            }
            HttpResponseMessage response = HttpClientRequest.PostResult("/Relation/MakeOrderOfLineUnActive/id", Convert.ToInt32(textBoxCityLineId.Text));
            if (response.IsSuccessStatusCode)
                MessageBox.Show("Uspjesno izbrisan dio redoslijeda voznje");
        }
    }
}
