﻿namespace eBusStation.Desktop
{
    partial class Diary_Regulator
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
            this.comboBoxTypeOfBus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTraveler = new System.Windows.Forms.ComboBox();
            this.buttonSearchBuses = new System.Windows.Forms.Button();
            this.dataGridViewBuses = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBusDelay = new System.Windows.Forms.Label();
            this.dateTimePickerBusDelay = new System.Windows.Forms.DateTimePicker();
            this.textBoxBusId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTypeOfBus
            // 
            this.comboBoxTypeOfBus.FormattingEnabled = true;
            this.comboBoxTypeOfBus.Location = new System.Drawing.Point(208, 39);
            this.comboBoxTypeOfBus.Name = "comboBoxTypeOfBus";
            this.comboBoxTypeOfBus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeOfBus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraga po tipu autobusa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pretraga po prevozniku";
            // 
            // comboBoxTraveler
            // 
            this.comboBoxTraveler.FormattingEnabled = true;
            this.comboBoxTraveler.Location = new System.Drawing.Point(208, 76);
            this.comboBoxTraveler.Name = "comboBoxTraveler";
            this.comboBoxTraveler.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTraveler.TabIndex = 3;
            // 
            // buttonSearchBuses
            // 
            this.buttonSearchBuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchBuses.Location = new System.Drawing.Point(231, 114);
            this.buttonSearchBuses.Name = "buttonSearchBuses";
            this.buttonSearchBuses.Size = new System.Drawing.Size(86, 26);
            this.buttonSearchBuses.TabIndex = 4;
            this.buttonSearchBuses.Text = "Pretraga";
            this.buttonSearchBuses.UseVisualStyleBackColor = true;
            this.buttonSearchBuses.Click += new System.EventHandler(this.buttonSearchBuses_Click);
            // 
            // dataGridViewBuses
            // 
            this.dataGridViewBuses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuses.Location = new System.Drawing.Point(0, 207);
            this.dataGridViewBuses.Name = "dataGridViewBuses";
            this.dataGridViewBuses.Size = new System.Drawing.Size(202, 220);
            this.dataGridViewBuses.TabIndex = 6;
            this.dataGridViewBuses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuses_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "AUTOBUS/REG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "DATUM DOLASKA/VRIJEME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "STANICA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(624, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "KASNIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(735, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "AKCIJA";
            // 
            // labelBusDelay
            // 
            this.labelBusDelay.AutoSize = true;
            this.labelBusDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusDelay.Location = new System.Drawing.Point(593, 135);
            this.labelBusDelay.Name = "labelBusDelay";
            this.labelBusDelay.Size = new System.Drawing.Size(115, 16);
            this.labelBusDelay.TabIndex = 13;
            this.labelBusDelay.Text = "Vrijeme kasnjenja";
            this.labelBusDelay.Visible = false;
            // 
            // dateTimePickerBusDelay
            // 
            this.dateTimePickerBusDelay.CustomFormat = "HH:mm";
            this.dateTimePickerBusDelay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBusDelay.Location = new System.Drawing.Point(596, 155);
            this.dateTimePickerBusDelay.Name = "dateTimePickerBusDelay";
            this.dateTimePickerBusDelay.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerBusDelay.TabIndex = 14;
            this.dateTimePickerBusDelay.Visible = false;
            // 
            // textBoxBusId
            // 
            this.textBoxBusId.Location = new System.Drawing.Point(596, 56);
            this.textBoxBusId.Name = "textBoxBusId";
            this.textBoxBusId.Size = new System.Drawing.Size(100, 20);
            this.textBoxBusId.TabIndex = 15;
            this.textBoxBusId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "BusId";
            this.label8.Visible = false;
            // 
            // Diary_Regulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxBusId);
            this.Controls.Add(this.dateTimePickerBusDelay);
            this.Controls.Add(this.labelBusDelay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewBuses);
            this.Controls.Add(this.buttonSearchBuses);
            this.Controls.Add(this.comboBoxTraveler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeOfBus);
            this.MaximizeBox = false;
            this.Name = "Diary_Regulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija saobracajnog dnevnika";
            this.Load += new System.EventHandler(this.Diary_Regulator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTypeOfBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTraveler;
        private System.Windows.Forms.Button buttonSearchBuses;
        private System.Windows.Forms.DataGridView dataGridViewBuses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelBusDelay;
        private System.Windows.Forms.DateTimePicker dateTimePickerBusDelay;
        private System.Windows.Forms.TextBox textBoxBusId;
        private System.Windows.Forms.Label label8;
    }
}