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
    public partial class RelationForm : Form
    {
        public RelationForm()
        {
            InitializeComponent();
        }

        private void RelationForm_Load(object sender, EventArgs e)
        {
            List<usp_Get_All_Cities_Result> citiesStart = new List<usp_Get_All_Cities_Result>();
            List<usp_Get_All_Cities_Result> citiesDestination;

            //Get all lines with traveler name.
            HttpResponseMessage response = HttpClientRequest.GetResult("/Relation/RelationWithTraveler");
            dataGridViewRelations.DataSource = response.Content.ReadAsAsync<List<usp_Get_Lines_With_Traveler_Result>>().Result;
            dataGridViewRelations.Columns["Id"].Visible = false;

            //Get all travelers
            HttpResponseMessage responseTravelers = HttpClientRequest.GetResult("/Traveler/Index");
            comboBoxTravelers.DataSource = responseTravelers.Content.ReadAsAsync<List<usp_Get_Travelers_Result>>().Result;
            comboBoxTravelers.DisplayMember = "Naziv";
            comboBoxTravelers.ValueMember = "Id";

            //Get a start city and destination city
            HttpResponseMessage cityResponse = HttpClientRequest.GetResult("/City/Index");
            citiesStart = cityResponse.Content.ReadAsAsync<List<usp_Get_All_Cities_Result>>().Result;
            citiesDestination = new List<usp_Get_All_Cities_Result>(citiesStart);

            comboBoxStartLine.DataSource = citiesStart;
            comboBoxStartLine.DisplayMember = "Naziv";
            comboBoxStartLine.ValueMember = "Id";

            comboBoxDestinationLine.DataSource = citiesDestination;
            comboBoxDestinationLine.DisplayMember = "Naziv";
            comboBoxStartLine.ValueMember = "Id";

            //Add button to make line unactive
            DataGridViewButtonColumn activeButton = new DataGridViewButtonColumn();
            activeButton.Name = "Neaktivna-aktivna";
            activeButton.Text = "Promjeni liniju u neaktivnu";
            activeButton.UseColumnTextForButtonValue = true;
            dataGridViewRelations.Columns.Insert(4, activeButton);

            dataGridViewRelations.CellClick += dataGridViewRelations_CellClick;
        }

        private void dataGridViewRelations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Initialize textboxes with cell clicked.
            string nameOfLine = dataGridViewRelations.Rows[e.RowIndex].Cells["Naziv_linije"].Value.ToString();
            int hyphenIndex = nameOfLine.IndexOf("-");

            comboBoxStartLine.Text = nameOfLine.Substring(0, hyphenIndex);
            comboBoxDestinationLine.Text = nameOfLine.Substring(hyphenIndex + 1, nameOfLine.Length-1 - hyphenIndex);
            comboBoxTravelers.Text = dataGridViewRelations.Rows[e.RowIndex].Cells["Prevoznik"].Value.ToString();
            comboBoxTypeLine.Text = dataGridViewRelations.Rows[e.RowIndex].Cells["Tip_linije"].Value.ToString();
            dateTimePickerLine.Text = dataGridViewRelations.Rows[e.RowIndex].Cells["Vrijeme_polaska"].Value.ToString();

            if (e.ColumnIndex == dataGridViewRelations.Columns["Neaktivna-aktivna"].Index)
            {
                //Make relation not active.
                HttpResponseMessage response = HttpClientRequest.PostResult("/Relation/MakeRelationUnActive/id", dataGridViewRelations.Rows[e.RowIndex].Cells["Id"].Value);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Linija je neaktivna");
            }
            textBoxLineId.Text = dataGridViewRelations.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        }

        private void buttonUpdateLine_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxLineId.Text))
            {
                MessageBox.Show("Molimo odaberite liniju za izmjenu");
                return;
            }
            Linije line = new Linije();
            line.Id = Convert.ToInt32(textBoxLineId.Text);
            line.PolazakId = Convert.ToInt32(comboBoxStartLine.SelectedValue);
            usp_Get_All_Cities_Result destination = comboBoxDestinationLine.SelectedValue as usp_Get_All_Cities_Result;

            line.DestinacijaId = destination.Id;
            line.Naziv = comboBoxStartLine.Text + "-" + comboBoxDestinationLine.Text;
            line.PrevoznikId = Convert.ToInt32(comboBoxTravelers.SelectedValue);
            line.TipLinije = comboBoxTypeLine.Text;
            line.vrijemePolaska = dateTimePickerLine.Text;

           HttpResponseMessage response =  HttpClientRequest.PostResult("/Relation/EditRelation", line);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Uspjesno izmjenjena linija");
                this.RelationForm_Load(sender,e);
            }
        }

        private void buttonAddLine_Click(object sender, EventArgs e)
        {
            //Add new line
            Linije line = new Linije();
            line.PolazakId = Convert.ToInt32(comboBoxStartLine.SelectedValue);
            usp_Get_All_Cities_Result destination = comboBoxDestinationLine.SelectedValue as usp_Get_All_Cities_Result;

            line.DestinacijaId = destination.Id;
            line.Naziv = comboBoxStartLine.Text + "-" + comboBoxDestinationLine.Text;
            line.PrevoznikId = Convert.ToInt32(comboBoxTravelers.SelectedValue);
            line.TipLinije = comboBoxTypeLine.Text;
            line.vrijemePolaska = dateTimePickerLine.Text;

            HttpResponseMessage response = HttpClientRequest.PostResult("/Relation/AddRelation", line);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Uspjesno dodana linija");
                this.RelationForm_Load(sender, e);
            }
        }

        private void buttonLineEarning_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLineId.Text))
            {
                MessageBox.Show("Molimo odaberite liniju da poogledate zaradu");
                return;
            }
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("lineId", textBoxLineId.Text);
            HttpResponseMessage response = HttpClientRequest.GetResult("/Relation/GetLineEarning/{lineId}", query);

            if (response.IsSuccessStatusCode)
            {
                dataGridViewRelations.DataSource = response.Content.ReadAsAsync<List<usp_Get_Line_Earnings_Result>>().Result;
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            RelationForm form = new RelationForm();
            form.ShowDialog();
            this.Close();
        }

        private void buttonReservationCounter_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = HttpClientRequest.GetResult("/Relation/GetLineReservationCounter");

            if (response.IsSuccessStatusCode)
            {
                dataGridViewRelations.DataSource = response.Content.ReadAsAsync<List<usp_Get_Reservation_Counter_On_Line_Result>>().Result;
            }
        }
    }
}
