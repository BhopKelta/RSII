namespace eBusStation.Desktop
{
    partial class Relation_Cities
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
            this.dataGridViewLines = new System.Windows.Forms.DataGridView();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTypeOfCard = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPriceFromBegin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPriceFromCurrent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerTimeOfComing = new System.Windows.Forms.DateTimePicker();
            this.buttonAddCityToLine = new System.Windows.Forms.Button();
            this.buttonUpdateCityInLine = new System.Windows.Forms.Button();
            this.textBoxLineId = new System.Windows.Forms.TextBox();
            this.LineId = new System.Windows.Forms.Label();
            this.textBoxCityLineId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRemoveLineOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLines
            // 
            this.dataGridViewLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewLines.Location = new System.Drawing.Point(0, 300);
            this.dataGridViewLines.Name = "dataGridViewLines";
            this.dataGridViewLines.Size = new System.Drawing.Size(800, 150);
            this.dataGridViewLines.TabIndex = 0;
            this.dataGridViewLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLines_CellContentClick);
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewCities.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCities.Location = new System.Drawing.Point(317, 0);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.Size = new System.Drawing.Size(483, 300);
            this.dataGridViewCities.TabIndex = 1;
            this.dataGridViewCities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCities_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "LINIJE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "GRADOVI";
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(40, 47);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCities.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grad";
            // 
            // comboBoxTypeOfCard
            // 
            this.comboBoxTypeOfCard.FormattingEnabled = true;
            this.comboBoxTypeOfCard.Items.AddRange(new object[] {
            "Obicna",
            "Studentska"});
            this.comboBoxTypeOfCard.Location = new System.Drawing.Point(40, 98);
            this.comboBoxTypeOfCard.Name = "comboBoxTypeOfCard";
            this.comboBoxTypeOfCard.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeOfCard.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tip karte";
            // 
            // textBoxPriceFromBegin
            // 
            this.textBoxPriceFromBegin.Location = new System.Drawing.Point(40, 147);
            this.textBoxPriceFromBegin.Name = "textBoxPriceFromBegin";
            this.textBoxPriceFromBegin.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriceFromBegin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cijena od pocetne stanice-grada\r\n";
            // 
            // textBoxPriceFromCurrent
            // 
            this.textBoxPriceFromCurrent.Location = new System.Drawing.Point(40, 193);
            this.textBoxPriceFromCurrent.Name = "textBoxPriceFromCurrent";
            this.textBoxPriceFromCurrent.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriceFromCurrent.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cijena od trenutne stanice - destinacije";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vrijeme dolaska";
            // 
            // dateTimePickerTimeOfComing
            // 
            this.dateTimePickerTimeOfComing.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimeOfComing.Location = new System.Drawing.Point(205, 48);
            this.dateTimePickerTimeOfComing.Name = "dateTimePickerTimeOfComing";
            this.dateTimePickerTimeOfComing.Size = new System.Drawing.Size(106, 20);
            this.dateTimePickerTimeOfComing.TabIndex = 14;
            // 
            // buttonAddCityToLine
            // 
            this.buttonAddCityToLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCityToLine.Location = new System.Drawing.Point(32, 219);
            this.buttonAddCityToLine.Name = "buttonAddCityToLine";
            this.buttonAddCityToLine.Size = new System.Drawing.Size(129, 28);
            this.buttonAddCityToLine.TabIndex = 15;
            this.buttonAddCityToLine.Text = "Dodaj u red voznje";
            this.buttonAddCityToLine.UseVisualStyleBackColor = true;
            this.buttonAddCityToLine.Click += new System.EventHandler(this.buttonAddCityToLine_Click);
            // 
            // buttonUpdateCityInLine
            // 
            this.buttonUpdateCityInLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCityInLine.Location = new System.Drawing.Point(164, 219);
            this.buttonUpdateCityInLine.Name = "buttonUpdateCityInLine";
            this.buttonUpdateCityInLine.Size = new System.Drawing.Size(125, 28);
            this.buttonUpdateCityInLine.TabIndex = 16;
            this.buttonUpdateCityInLine.Text = "Izmjeni red voznje";
            this.buttonUpdateCityInLine.UseVisualStyleBackColor = true;
            this.buttonUpdateCityInLine.Click += new System.EventHandler(this.buttonUpdateCityInLine_Click);
            // 
            // textBoxLineId
            // 
            this.textBoxLineId.Location = new System.Drawing.Point(205, 91);
            this.textBoxLineId.Name = "textBoxLineId";
            this.textBoxLineId.Size = new System.Drawing.Size(106, 20);
            this.textBoxLineId.TabIndex = 17;
            this.textBoxLineId.Visible = false;
            // 
            // LineId
            // 
            this.LineId.AutoSize = true;
            this.LineId.Location = new System.Drawing.Point(204, 75);
            this.LineId.Name = "LineId";
            this.LineId.Size = new System.Drawing.Size(36, 13);
            this.LineId.TabIndex = 18;
            this.LineId.Text = "LineId";
            this.LineId.Visible = false;
            // 
            // textBoxCityLineId
            // 
            this.textBoxCityLineId.Location = new System.Drawing.Point(207, 151);
            this.textBoxCityLineId.Name = "textBoxCityLineId";
            this.textBoxCityLineId.Size = new System.Drawing.Size(100, 20);
            this.textBoxCityLineId.TabIndex = 19;
            this.textBoxCityLineId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "CityLineId";
            this.label8.Visible = false;
            // 
            // buttonRemoveLineOrder
            // 
            this.buttonRemoveLineOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveLineOrder.Location = new System.Drawing.Point(94, 245);
            this.buttonRemoveLineOrder.Name = "buttonRemoveLineOrder";
            this.buttonRemoveLineOrder.Size = new System.Drawing.Size(126, 32);
            this.buttonRemoveLineOrder.TabIndex = 21;
            this.buttonRemoveLineOrder.Text = "Ukloni dio voznje";
            this.buttonRemoveLineOrder.UseVisualStyleBackColor = true;
            this.buttonRemoveLineOrder.Click += new System.EventHandler(this.buttonRemoveLineOrder_Click);
            // 
            // Relation_Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoveLineOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCityLineId);
            this.Controls.Add(this.LineId);
            this.Controls.Add(this.textBoxLineId);
            this.Controls.Add(this.buttonUpdateCityInLine);
            this.Controls.Add(this.buttonAddCityToLine);
            this.Controls.Add(this.dateTimePickerTimeOfComing);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPriceFromCurrent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPriceFromBegin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTypeOfCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCities);
            this.Controls.Add(this.dataGridViewLines);
            this.MaximizeBox = false;
            this.Name = "Relation_Cities";
            this.Text = "Azuriranje lokacija kroz koje prolazi linija  i cijene karata";
            this.Load += new System.EventHandler(this.Relation_Cities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLines;
        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTypeOfCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPriceFromBegin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPriceFromCurrent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeOfComing;
        private System.Windows.Forms.Button buttonAddCityToLine;
        private System.Windows.Forms.Button buttonUpdateCityInLine;
        private System.Windows.Forms.TextBox textBoxLineId;
        private System.Windows.Forms.Label LineId;
        private System.Windows.Forms.TextBox textBoxCityLineId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRemoveLineOrder;
    }
}