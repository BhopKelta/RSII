using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBusStation.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotificationForm form = new NotificationForm();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diary_Regulator form = new Diary_Regulator();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Relation_Cities form = new Relation_Cities();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RelationForm form = new RelationForm();
            form.ShowDialog();
            this.Close();
        }

        private void buttonOpenFirstReport_Click(object sender, EventArgs e)
        {
            ReportingLineEarning report = new ReportingLineEarning();
            report.ReportingLineEarning_Load_Data(sender,e);
            report.ShowDialog();
        }

        private void buttonOpenReservationCounterReport_Click(object sender, EventArgs e)
        {
            ReportingLineEarning report = new ReportingLineEarning();
            report.ReportingLineCounter_Load_Data(sender, e);
            report.ShowDialog();
        }

        private void buttonAddBusPicture_Click(object sender, EventArgs e)
        {
            BusStoringImages imageAddToBus = new BusStoringImages();
            imageAddToBus.ShowDialog();
        }

        private void buttonAddNewBus_Click(object sender, EventArgs e)
        {
            NewBusInStation addNewBus = new NewBusInStation();
            addNewBus.ShowDialog();
        }
    }
}
