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
using eBusStation.Desktop.Properties;
using Newtonsoft.Json;

namespace eBusStation.Desktop
{
    public partial class Diary_Regulator : Form
    {
        public Diary_Regulator()
        {
            InitializeComponent();
        }

        private void Diary_Regulator_Load(object sender, EventArgs e)
        {
            //Get all travelers
            HttpResponseMessage response = HttpClientRequest.GetResult("/Traveler/Index",null, Properties.Settings.Default.apiURL);
            comboBoxTraveler.DataSource = response.Content.ReadAsAsync<List<usp_Get_Travelers_Result>>().Result;
            comboBoxTraveler.DisplayMember = "Naziv";
            comboBoxTraveler.ValueMember = "Id";

            //Get all type of buses
            HttpResponseMessage busResponse = HttpClientRequest.GetResult("/Bus/GetTypesOfBuses",null, Properties.Settings.Default.apiURL);
            comboBoxTypeOfBus.DataSource = busResponse.Content.ReadAsAsync<List<usp_Get_Types_Of_Buses_Result>>().Result;
            comboBoxTypeOfBus.DisplayMember = "Tip";
            comboBoxTypeOfBus.ValueMember = "Id";
        }

        private void buttonSearchBuses_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("travelerId", comboBoxTraveler.SelectedValue.ToString());
            query.Add("typeOfBusId", comboBoxTypeOfBus.SelectedValue.ToString());
            HttpResponseMessage response = HttpClientRequest.GetResult("/Bus/SearchBuses", query);

            HttpResponseMessage cityResponse = HttpClientRequest.GetResult("/City/Index",null, Settings.Default.apiURL);
            List<usp_Get_All_Cities_Result> cities = cityResponse.Content.ReadAsAsync<List<usp_Get_All_Cities_Result>>().Result;

            if (response.IsSuccessStatusCode)
            {
                dataGridViewBuses.DataSource = response.Content.ReadAsAsync<List<usp_Search_Buses_Result>>().Result;
                dataGridViewBuses.Columns["AutobusId"].Visible = false;
            }
            for (int j = 0; j < dataGridViewBuses.RowCount; j++)
            {
                for (int k = 0; k < dataGridViewBuses.ColumnCount - 2; k++)
                {
                    //Create buttons, datetimepickr in runtime
                    DateTimePicker textbox = new DateTimePicker();
                    textbox.Name = "textBoxTimeOfComing" + k;
                    textbox.Size = new Size(150, 35);

                    textbox.Format = DateTimePickerFormat.Custom;
                    textbox.CustomFormat = "dd-MM-yyyy HH:mm";
                    Point newPoint = dataGridViewBuses.GetCellDisplayRectangle(k, j, false).Location;
                    newPoint.Y -= 150;
                    newPoint.X -= 75;
                    textbox.Location = dataGridViewBuses.PointToScreen(newPoint);
                    this.Controls.Add(textbox);

                    ComboBox combobox = new ComboBox();
                    combobox.DataSource = new List<usp_Get_All_Cities_Result>(cities);
                    combobox.DisplayMember = "Naziv";
                    combobox.ValueMember = "Id";

                    newPoint.X += 185;
                    combobox.Location = dataGridViewBuses.PointToScreen(newPoint);
                    this.Controls.Add(combobox);

                    CheckBox checkbox = new CheckBox();
                    checkbox.Checked = false;
                    checkbox.Name = "checkBoxBusDelay";
                    checkbox.CheckedChanged += (s, eve) =>
                    {
                        //Show textbox for time of delay
                        if (checkbox.Checked)
                        {
                            this.dateTimePickerBusDelay.Visible = true;
                            this.labelBusDelay.Visible = true;
                        }
                        else
                        {
                            this.dateTimePickerBusDelay.Visible = false;
                            this.labelBusDelay.Visible = false;
                        }
                    };

                    newPoint.X += 165;
                    checkbox.Location = dataGridViewBuses.PointToScreen(newPoint);
                    this.Controls.Add(checkbox);

                    Button save = new Button();
                    save.Text = "Snimi";

                    //Save into database  diary.
                    save.Click += (s, eve) =>
                    {
                        if (textBoxBusId.Text == "")
                        {
                            MessageBox.Show("Molimo odaberite bus");
                            return;
                        }
                        if (checkbox.Checked)
                        {
                            if (dateTimePickerBusDelay.Text == "")
                            {
                                MessageBox.Show("Molimo unesite vrijeme kasnjenja za bus -ako kasni");
                                return;
                            }
                        }
                        if (textbox.Text == "")
                        {
                            MessageBox.Show("Molimo unestie vrijeme dolaska na stanicu");
                            return;
                        }

                        //Get station by city
                        IDictionary<string, string> queryStation = new Dictionary<string, string>();
                        queryStation.Add("cityId", combobox.SelectedValue.ToString());
                        HttpResponseMessage stationResponse = HttpClientRequest.GetResult("/Station/GetStation", queryStation,Properties.Settings.Default.apiURL);

                        int? stationId= 0;
                        if (stationResponse.IsSuccessStatusCode)
                        {
                            stationId = stationResponse.Content.ReadAsAsync<int?>().Result;
                        }
                        SaobracajniDnevnik diary = new SaobracajniDnevnik
                        {
                            daLiJeKansnio = checkbox.Checked,
                            StanicaId = (int)stationId,
                            UposlenikId = Convert.ToInt32(Properties.Settings.Default.uposlenikId),
                            vrijemeDolaska = Convert.ToDateTime(textbox.Text),
                        };
                        if (checkbox.Checked)
                            diary.vrijemeKasnjena = dateTimePickerBusDelay.Text;
                        else
                            diary.vrijemeKasnjena = "";

                        HttpResponseMessage postResult = HttpClientRequest.PostResult("/Bus/RememberBusCameOnStation", diary);
                        if (postResult.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Uspjesno sacuvan dolazni bus na stanicu..");
                        }
                    };

                    newPoint.X += 60;
                    save.Size = new Size(160, 20);
                    save.Location = dataGridViewBuses.PointToScreen(newPoint);

                    this.Controls.Add(save);
                }
            }
        }

        private void dataGridViewBuses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBusId.Text = dataGridViewBuses.Rows[e.RowIndex].Cells["AutobusId"].Value.ToString();
        }
    }
}
