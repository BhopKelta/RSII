using eBusStation.API.Models;
using eBusStation.API.Static;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
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
    public partial class ReportingLineEarning : Form
    {
        public ReportingLineEarning()
        {
            InitializeComponent();
            this.Controls.Add(reportViewerFirst);

        }

        private void reportViewerFirst_Load(object sender, EventArgs e)
        {
        }

        public void ReportingLineEarning_Load_Data(object sender, EventArgs e)
        {
            //Line earning report
            HttpResponseMessage reportResponse = HttpClientRequest.GetResult("/Relation/GetLineEarning");
            if (reportResponse.IsSuccessStatusCode)
            {
                List<usp_Get_Line_Earnings_Result> lineEarnings =
                    JsonConvert.DeserializeObject<List<usp_Get_Line_Earnings_Result>>(reportResponse.Content.ReadAsStringAsync().Result);

                DataSets.FirstReport.FirstReportDataTable dataTable = new DataSets.FirstReport.FirstReportDataTable();
                foreach (var item in lineEarnings)
                {
                    if (item.Zarada.Value != null)
                    {
                        double suming = item.Zarada.Value;
                        dataTable.AddFirstReportRow(item.Naziv, suming);
                    }
                }
                ReportDataSource datasource = new ReportDataSource("DataSet1",dataTable.ToList());
                reportViewerFirst.LocalReport.ReportPath = "../../FirstReport.rdlc";
                reportViewerFirst.LocalReport.DataSources.Clear();
                reportViewerFirst.LocalReport.DataSources.Add(datasource);
                reportViewerFirst.LocalReport.Refresh();
                reportViewerFirst.ZoomMode = ZoomMode.PageWidth;
                reportViewerFirst.RefreshReport();
            }
        }
        public void ReportingLineCounter_Load_Data(object sender,EventArgs e)
        {
            HttpResponseMessage reportLineReservationsCounter = HttpClientRequest.GetResult("/Relation/GetLineReservationCounter");
            if(reportLineReservationsCounter.IsSuccessStatusCode)
            {
                List<usp_Get_Reservation_Counter_On_Line_Result> lineReservationCounter =
                    JsonConvert.DeserializeObject<List<usp_Get_Reservation_Counter_On_Line_Result>>(reportLineReservationsCounter.Content.ReadAsStringAsync().Result);
                DataSets.Line_Counter_Reservations_By_Month.DataTable1DataTable dataTable = new DataSets.Line_Counter_Reservations_By_Month.DataTable1DataTable();
                foreach (var item in lineReservationCounter)
                {
                    dataTable.AddDataTable1Row(item.Naziv, item.BrojProdatihKarataPoMjesecima.ToString(), item.Mjesec.ToString());
                }
                ReportDataSource datasource = new ReportDataSource("DataSet2", dataTable.ToList());
                reportViewerFirst.LocalReport.ReportPath = "../../SecondReportLineReservationCounter.rdlc";
                reportViewerFirst.LocalReport.DataSources.Clear();
                reportViewerFirst.LocalReport.DataSources.Add(datasource);
                reportViewerFirst.LocalReport.Refresh();
                reportViewerFirst.ZoomMode = ZoomMode.FullPage;
                reportViewerFirst.RefreshReport();
            }
        }
    }
}
