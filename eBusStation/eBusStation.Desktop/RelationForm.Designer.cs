namespace eBusStation.Desktop
{
    partial class RelationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRelations = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerLine = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStartLine = new System.Windows.Forms.ComboBox();
            this.comboBoxDestinationLine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTypeLine = new System.Windows.Forms.ComboBox();
            this.comboBoxTravelers = new System.Windows.Forms.ComboBox();
            this.buttonUpdateLine = new System.Windows.Forms.Button();
            this.textBoxLineId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddLine = new System.Windows.Forms.Button();
            this.buttonLineEarning = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonReservationCounter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "AKTIVNE LINIJE";
            // 
            // dataGridViewRelations
            // 
            this.dataGridViewRelations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRelations.Location = new System.Drawing.Point(0, 220);
            this.dataGridViewRelations.Name = "dataGridViewRelations";
            this.dataGridViewRelations.Size = new System.Drawing.Size(813, 230);
            this.dataGridViewRelations.TabIndex = 1;
            this.dataGridViewRelations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRelations_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prevoznik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tip linije";
            // 
            // dateTimePickerLine
            // 
            this.dateTimePickerLine.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerLine.Location = new System.Drawing.Point(556, 106);
            this.dateTimePickerLine.Name = "dateTimePickerLine";
            this.dateTimePickerLine.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLine.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vrijeme polaska";
            // 
            // comboBoxStartLine
            // 
            this.comboBoxStartLine.FormattingEnabled = true;
            this.comboBoxStartLine.Location = new System.Drawing.Point(33, 49);
            this.comboBoxStartLine.Name = "comboBoxStartLine";
            this.comboBoxStartLine.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStartLine.TabIndex = 10;
            // 
            // comboBoxDestinationLine
            // 
            this.comboBoxDestinationLine.FormattingEnabled = true;
            this.comboBoxDestinationLine.Location = new System.Drawing.Point(33, 105);
            this.comboBoxDestinationLine.Name = "comboBoxDestinationLine";
            this.comboBoxDestinationLine.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestinationLine.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Polazak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Destinacija";
            // 
            // comboBoxTypeLine
            // 
            this.comboBoxTypeLine.FormattingEnabled = true;
            this.comboBoxTypeLine.Items.AddRange(new object[] {
            "Redovna",
            "Vandredna"});
            this.comboBoxTypeLine.Location = new System.Drawing.Point(393, 106);
            this.comboBoxTypeLine.Name = "comboBoxTypeLine";
            this.comboBoxTypeLine.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeLine.TabIndex = 14;
            // 
            // comboBoxTravelers
            // 
            this.comboBoxTravelers.FormattingEnabled = true;
            this.comboBoxTravelers.Location = new System.Drawing.Point(238, 105);
            this.comboBoxTravelers.Name = "comboBoxTravelers";
            this.comboBoxTravelers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTravelers.TabIndex = 15;
            // 
            // buttonUpdateLine
            // 
            this.buttonUpdateLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateLine.Location = new System.Drawing.Point(700, 161);
            this.buttonUpdateLine.Name = "buttonUpdateLine";
            this.buttonUpdateLine.Size = new System.Drawing.Size(101, 26);
            this.buttonUpdateLine.TabIndex = 16;
            this.buttonUpdateLine.Text = "Izmijeni liniju";
            this.buttonUpdateLine.UseVisualStyleBackColor = true;
            this.buttonUpdateLine.Click += new System.EventHandler(this.buttonUpdateLine_Click);
            // 
            // textBoxLineId
            // 
            this.textBoxLineId.Location = new System.Drawing.Point(54, 167);
            this.textBoxLineId.Name = "textBoxLineId";
            this.textBoxLineId.Size = new System.Drawing.Size(100, 20);
            this.textBoxLineId.TabIndex = 17;
            this.textBoxLineId.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "LinijaId";
            this.label7.Visible = false;
            // 
            // buttonAddLine
            // 
            this.buttonAddLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddLine.Location = new System.Drawing.Point(596, 161);
            this.buttonAddLine.Name = "buttonAddLine";
            this.buttonAddLine.Size = new System.Drawing.Size(95, 26);
            this.buttonAddLine.TabIndex = 19;
            this.buttonAddLine.Text = "Dodaj liniju";
            this.buttonAddLine.UseVisualStyleBackColor = true;
            this.buttonAddLine.Click += new System.EventHandler(this.buttonAddLine_Click);
            // 
            // buttonLineEarning
            // 
            this.buttonLineEarning.Location = new System.Drawing.Point(388, 163);
            this.buttonLineEarning.Name = "buttonLineEarning";
            this.buttonLineEarning.Size = new System.Drawing.Size(121, 28);
            this.buttonLineEarning.TabIndex = 20;
            this.buttonLineEarning.Text = "Pogledaj zaradu linije";
            this.buttonLineEarning.UseVisualStyleBackColor = true;
            this.buttonLineEarning.Click += new System.EventHandler(this.buttonLineEarning_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(615, 28);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(95, 23);
            this.buttonHome.TabIndex = 21;
            this.buttonHome.Text = "Pocetno stanje";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonReservationCounter
            // 
            this.buttonReservationCounter.Location = new System.Drawing.Point(219, 163);
            this.buttonReservationCounter.Name = "buttonReservationCounter";
            this.buttonReservationCounter.Size = new System.Drawing.Size(140, 25);
            this.buttonReservationCounter.TabIndex = 22;
            this.buttonReservationCounter.Text = "Pogledaj broj rezervacija";
            this.buttonReservationCounter.UseVisualStyleBackColor = true;
            this.buttonReservationCounter.Click += new System.EventHandler(this.buttonReservationCounter_Click);
            // 
            // RelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.buttonReservationCounter);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonLineEarning);
            this.Controls.Add(this.buttonAddLine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLineId);
            this.Controls.Add(this.buttonUpdateLine);
            this.Controls.Add(this.comboBoxTravelers);
            this.Controls.Add(this.comboBoxTypeLine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDestinationLine);
            this.Controls.Add(this.comboBoxStartLine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerLine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewRelations);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RelationForm";
            this.Text = "Evidencija ponuda - linija";
            this.Load += new System.EventHandler(this.RelationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRelations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStartLine;
        private System.Windows.Forms.ComboBox comboBoxDestinationLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTypeLine;
        private System.Windows.Forms.ComboBox comboBoxTravelers;
        private System.Windows.Forms.Button buttonUpdateLine;
        private System.Windows.Forms.TextBox textBoxLineId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddLine;
        private System.Windows.Forms.Button buttonLineEarning;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonReservationCounter;
    }
}