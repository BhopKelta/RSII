namespace eBusStation.Desktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenFirstReport = new System.Windows.Forms.Button();
            this.buttonOpenReservationCounterReport = new System.Windows.Forms.Button();
            this.buttonAddBusPicture = new System.Windows.Forms.Button();
            this.buttonAddNewBus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::eBusStation.Desktop.Properties.Resources.exit;
            this.pictureBox5.Location = new System.Drawing.Point(12, 285);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(193, 139);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::eBusStation.Desktop.Properties.Resources.travel;
            this.pictureBox4.Location = new System.Drawing.Point(539, 285);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(207, 153);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::eBusStation.Desktop.Properties.Resources.karte;
            this.pictureBox3.Location = new System.Drawing.Point(539, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 142);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eBusStation.Desktop.Properties.Resources.diary;
            this.pictureBox2.Location = new System.Drawing.Point(259, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eBusStation.Desktop.Properties.Resources.Info_300x300;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonOpenFirstReport
            // 
            this.buttonOpenFirstReport.Location = new System.Drawing.Point(297, 50);
            this.buttonOpenFirstReport.Name = "buttonOpenFirstReport";
            this.buttonOpenFirstReport.Size = new System.Drawing.Size(148, 42);
            this.buttonOpenFirstReport.TabIndex = 5;
            this.buttonOpenFirstReport.Text = "Izvjestaj o zaradi linija";
            this.buttonOpenFirstReport.UseVisualStyleBackColor = true;
            this.buttonOpenFirstReport.Click += new System.EventHandler(this.buttonOpenFirstReport_Click);
            // 
            // buttonOpenReservationCounterReport
            // 
            this.buttonOpenReservationCounterReport.Location = new System.Drawing.Point(297, 367);
            this.buttonOpenReservationCounterReport.Name = "buttonOpenReservationCounterReport";
            this.buttonOpenReservationCounterReport.Size = new System.Drawing.Size(148, 41);
            this.buttonOpenReservationCounterReport.TabIndex = 6;
            this.buttonOpenReservationCounterReport.Text = "Izvjestaj o broju rezervacija mjesecno";
            this.buttonOpenReservationCounterReport.UseVisualStyleBackColor = true;
            this.buttonOpenReservationCounterReport.Click += new System.EventHandler(this.buttonOpenReservationCounterReport_Click);
            // 
            // buttonAddBusPicture
            // 
            this.buttonAddBusPicture.Location = new System.Drawing.Point(616, 220);
            this.buttonAddBusPicture.Name = "buttonAddBusPicture";
            this.buttonAddBusPicture.Size = new System.Drawing.Size(130, 31);
            this.buttonAddBusPicture.TabIndex = 7;
            this.buttonAddBusPicture.Text = "Dodaj sliku autobusu";
            this.buttonAddBusPicture.UseVisualStyleBackColor = true;
            this.buttonAddBusPicture.Click += new System.EventHandler(this.buttonAddBusPicture_Click);
            // 
            // buttonAddNewBus
            // 
            this.buttonAddNewBus.Location = new System.Drawing.Point(34, 220);
            this.buttonAddNewBus.Name = "buttonAddNewBus";
            this.buttonAddNewBus.Size = new System.Drawing.Size(116, 31);
            this.buttonAddNewBus.TabIndex = 8;
            this.buttonAddNewBus.Text = "Dodaj novi autobus";
            this.buttonAddNewBus.UseVisualStyleBackColor = true;
            this.buttonAddNewBus.Click += new System.EventHandler(this.buttonAddNewBus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddNewBus);
            this.Controls.Add(this.buttonAddBusPicture);
            this.Controls.Add(this.buttonOpenReservationCounterReport);
            this.Controls.Add(this.buttonOpenFirstReport);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Glavna forma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonOpenFirstReport;
        private System.Windows.Forms.Button buttonOpenReservationCounterReport;
        private System.Windows.Forms.Button buttonAddBusPicture;
        private System.Windows.Forms.Button buttonAddNewBus;
    }
}