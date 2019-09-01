namespace eBusStation.Desktop
{
    partial class NotificationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddNotification = new System.Windows.Forms.Button();
            this.buttonEditNotification = new System.Windows.Forms.Button();
            this.comboBoxNotificationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDateExpiracy = new System.Windows.Forms.TextBox();
            this.labelDateExpiracy = new System.Windows.Forms.Label();
            this.textBoxTextOfNotification = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSaveNotification = new System.Windows.Forms.Button();
            this.dataGridViewRelations = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLineId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonOpenNotification = new System.Windows.Forms.Button();
            this.buttonOpenLines = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eBusStation.Desktop.Properties.Resources.Info_300x300;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddNotification
            // 
            this.buttonAddNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNotification.Location = new System.Drawing.Point(307, 3);
            this.buttonAddNotification.Name = "buttonAddNotification";
            this.buttonAddNotification.Size = new System.Drawing.Size(155, 23);
            this.buttonAddNotification.TabIndex = 1;
            this.buttonAddNotification.Text = "Nova obavijest";
            this.buttonAddNotification.UseVisualStyleBackColor = true;
            this.buttonAddNotification.Click += new System.EventHandler(this.buttonAddNotification_Click);
            // 
            // buttonEditNotification
            // 
            this.buttonEditNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditNotification.Location = new System.Drawing.Point(489, 3);
            this.buttonEditNotification.Name = "buttonEditNotification";
            this.buttonEditNotification.Size = new System.Drawing.Size(155, 23);
            this.buttonEditNotification.TabIndex = 2;
            this.buttonEditNotification.Text = "Uredi postojeću";
            this.buttonEditNotification.UseVisualStyleBackColor = true;
            this.buttonEditNotification.Click += new System.EventHandler(this.buttonEditNotification_Click);
            // 
            // comboBoxNotificationType
            // 
            this.comboBoxNotificationType.FormattingEnabled = true;
            this.comboBoxNotificationType.Items.AddRange(new object[] {
            "Obavijest",
            "Popust"});
            this.comboBoxNotificationType.Location = new System.Drawing.Point(633, 58);
            this.comboBoxNotificationType.Name = "comboBoxNotificationType";
            this.comboBoxNotificationType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNotificationType.TabIndex = 3;
            this.comboBoxNotificationType.SelectedIndexChanged += new System.EventHandler(this.comboBoxNotificationType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tip";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(633, 206);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(121, 20);
            this.textBoxDiscount.TabIndex = 5;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(565, 206);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(62, 16);
            this.labelDiscount.TabIndex = 6;
            this.labelDiscount.Text = "Popust%";
            // 
            // textBoxDateExpiracy
            // 
            this.textBoxDateExpiracy.Location = new System.Drawing.Point(633, 169);
            this.textBoxDateExpiracy.Name = "textBoxDateExpiracy";
            this.textBoxDateExpiracy.Size = new System.Drawing.Size(121, 20);
            this.textBoxDateExpiracy.TabIndex = 7;
            // 
            // labelDateExpiracy
            // 
            this.labelDateExpiracy.AutoSize = true;
            this.labelDateExpiracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateExpiracy.Location = new System.Drawing.Point(530, 169);
            this.labelDateExpiracy.Name = "labelDateExpiracy";
            this.labelDateExpiracy.Size = new System.Drawing.Size(97, 16);
            this.labelDateExpiracy.TabIndex = 8;
            this.labelDateExpiracy.Text = "Datum važenja";
            // 
            // textBoxTextOfNotification
            // 
            this.textBoxTextOfNotification.Location = new System.Drawing.Point(568, 103);
            this.textBoxTextOfNotification.Multiline = true;
            this.textBoxTextOfNotification.Name = "textBoxTextOfNotification";
            this.textBoxTextOfNotification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTextOfNotification.Size = new System.Drawing.Size(186, 37);
            this.textBoxTextOfNotification.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Napomena";
            // 
            // buttonSaveNotification
            // 
            this.buttonSaveNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveNotification.Location = new System.Drawing.Point(687, 241);
            this.buttonSaveNotification.Name = "buttonSaveNotification";
            this.buttonSaveNotification.Size = new System.Drawing.Size(91, 23);
            this.buttonSaveNotification.TabIndex = 11;
            this.buttonSaveNotification.Text = "SNIMI";
            this.buttonSaveNotification.UseVisualStyleBackColor = true;
            this.buttonSaveNotification.Click += new System.EventHandler(this.buttonSaveNotification_Click);
            // 
            // dataGridViewRelations
            // 
            this.dataGridViewRelations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRelations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRelations.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewRelations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRelations.Location = new System.Drawing.Point(0, 321);
            this.dataGridViewRelations.Name = "dataGridViewRelations";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewRelations.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewRelations.Size = new System.Drawing.Size(790, 162);
            this.dataGridViewRelations.TabIndex = 12;
            this.dataGridViewRelations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRelations_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "LINIJE";
            // 
            // textBoxLineId
            // 
            this.textBoxLineId.Location = new System.Drawing.Point(319, 131);
            this.textBoxLineId.Name = "textBoxLineId";
            this.textBoxLineId.Size = new System.Drawing.Size(100, 20);
            this.textBoxLineId.TabIndex = 14;
            this.textBoxLineId.Visible = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(329, 117);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 15;
            this.labelId.Text = "Id";
            this.labelId.Visible = false;
            // 
            // buttonOpenNotification
            // 
            this.buttonOpenNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenNotification.Location = new System.Drawing.Point(687, 281);
            this.buttonOpenNotification.Name = "buttonOpenNotification";
            this.buttonOpenNotification.Size = new System.Drawing.Size(104, 33);
            this.buttonOpenNotification.TabIndex = 16;
            this.buttonOpenNotification.Text = "Obavijesti";
            this.buttonOpenNotification.UseVisualStyleBackColor = true;
            this.buttonOpenNotification.Click += new System.EventHandler(this.buttonOpenNotification_Click);
            // 
            // buttonOpenLines
            // 
            this.buttonOpenLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenLines.Location = new System.Drawing.Point(588, 281);
            this.buttonOpenLines.Name = "buttonOpenLines";
            this.buttonOpenLines.Size = new System.Drawing.Size(93, 33);
            this.buttonOpenLines.TabIndex = 17;
            this.buttonOpenLines.Text = "Linije";
            this.buttonOpenLines.UseVisualStyleBackColor = true;
            this.buttonOpenLines.Click += new System.EventHandler(this.buttonOpenLines_Click);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 483);
            this.Controls.Add(this.buttonOpenLines);
            this.Controls.Add(this.buttonOpenNotification);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxLineId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewRelations);
            this.Controls.Add(this.buttonSaveNotification);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTextOfNotification);
            this.Controls.Add(this.labelDateExpiracy);
            this.Controls.Add(this.textBoxDateExpiracy);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNotificationType);
            this.Controls.Add(this.buttonEditNotification);
            this.Controls.Add(this.buttonAddNotification);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NotificationForm";
            this.Text = "Evidencija obavijesti/popusta";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddNotification;
        private System.Windows.Forms.Button buttonEditNotification;
        private System.Windows.Forms.ComboBox comboBoxNotificationType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDateExpiracy;
        private System.Windows.Forms.Label labelDateExpiracy;
        private System.Windows.Forms.TextBox textBoxTextOfNotification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSaveNotification;
        private System.Windows.Forms.DataGridView dataGridViewRelations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLineId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonOpenNotification;
        private System.Windows.Forms.Button buttonOpenLines;
    }
}