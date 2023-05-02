namespace MobileShop2023.PL
{
    partial class Form_Spents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Spents));
            this.label14 = new System.Windows.Forms.Label();
            this.btn_SAVE = new System.Windows.Forms.Button();
            this.btn_EXIT = new System.Windows.Forms.Button();
            this.btn_ERASE = new System.Windows.Forms.Button();
            this.DTM_Spent = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.T_SpentPrice = new System.Windows.Forms.TextBox();
            this.T_Name = new System.Windows.Forms.TextBox();
            this.T_SpentKind = new System.Windows.Forms.TextBox();
            this.T_HijriDate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(47, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 29);
            this.label14.TabIndex = 1474;
            this.label14.Text = "تاريخ المصروف";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SAVE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SAVE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SAVE.Image = ((System.Drawing.Image)(resources.GetObject("btn_SAVE.Image")));
            this.btn_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SAVE.Location = new System.Drawing.Point(28, 197);
            this.btn_SAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SAVE.Name = "btn_SAVE";
            this.btn_SAVE.Size = new System.Drawing.Size(416, 53);
            this.btn_SAVE.TabIndex = 4;
            this.btn_SAVE.Text = "حفظ";
            this.btn_SAVE.UseVisualStyleBackColor = false;
            this.btn_SAVE.Click += new System.EventHandler(this.btn_SAVE_Click);
            this.btn_SAVE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SpentKind_KeyDown);
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EXIT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_EXIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EXIT.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EXIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("btn_EXIT.Image")));
            this.btn_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EXIT.Location = new System.Drawing.Point(220, 249);
            this.btn_EXIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(224, 53);
            this.btn_EXIT.TabIndex = 1479;
            this.btn_EXIT.Text = "خروج";
            this.btn_EXIT.UseVisualStyleBackColor = false;
            this.btn_EXIT.Click += new System.EventHandler(this.btn_EXIT_Click);
            // 
            // btn_ERASE
            // 
            this.btn_ERASE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ERASE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ERASE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ERASE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ERASE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ERASE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ERASE.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ERASE.Image = ((System.Drawing.Image)(resources.GetObject("btn_ERASE.Image")));
            this.btn_ERASE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ERASE.Location = new System.Drawing.Point(28, 249);
            this.btn_ERASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ERASE.Name = "btn_ERASE";
            this.btn_ERASE.Size = new System.Drawing.Size(193, 53);
            this.btn_ERASE.TabIndex = 1478;
            this.btn_ERASE.Text = "مسح";
            this.btn_ERASE.UseVisualStyleBackColor = false;
            this.btn_ERASE.Click += new System.EventHandler(this.btn_ERASE_Click);
            // 
            // DTM_Spent
            // 
            this.DTM_Spent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTM_Spent.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTM_Spent.CausesValidation = false;
            this.DTM_Spent.Checked = false;
            this.DTM_Spent.CustomFormat = "yyyy-MM-dd";
            this.DTM_Spent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTM_Spent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTM_Spent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTM_Spent.Location = new System.Drawing.Point(173, 90);
            this.DTM_Spent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTM_Spent.Name = "DTM_Spent";
            this.DTM_Spent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DTM_Spent.RightToLeftLayout = true;
            this.DTM_Spent.Size = new System.Drawing.Size(140, 29);
            this.DTM_Spent.TabIndex = 2;
            this.DTM_Spent.Value = new System.DateTime(2014, 5, 4, 0, 0, 0, 0);
            this.DTM_Spent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SpentKind_KeyDown);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(47, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 29);
            this.label12.TabIndex = 1473;
            this.label12.Text = "القيمة";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(47, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 31);
            this.label10.TabIndex = 1471;
            this.label10.Text = "الاسم";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(47, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 29);
            this.label9.TabIndex = 1470;
            this.label9.Text = "نوع المصروف";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_SpentPrice
            // 
            this.T_SpentPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_SpentPrice.BackColor = System.Drawing.Color.White;
            this.T_SpentPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_SpentPrice.ForeColor = System.Drawing.Color.Blue;
            this.T_SpentPrice.Location = new System.Drawing.Point(172, 62);
            this.T_SpentPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_SpentPrice.Name = "T_SpentPrice";
            this.T_SpentPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_SpentPrice.Size = new System.Drawing.Size(254, 31);
            this.T_SpentPrice.TabIndex = 1;
            this.T_SpentPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_SpentPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SpentKind_KeyDown);
            this.T_SpentPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_SpentPrice_KeyPress);
            // 
            // T_Name
            // 
            this.T_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Name.BackColor = System.Drawing.Color.White;
            this.T_Name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Name.ForeColor = System.Drawing.Color.Blue;
            this.T_Name.Location = new System.Drawing.Point(173, 118);
            this.T_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Name.Name = "T_Name";
            this.T_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Name.Size = new System.Drawing.Size(253, 31);
            this.T_Name.TabIndex = 3;
            this.T_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SpentKind_KeyDown);
            // 
            // T_SpentKind
            // 
            this.T_SpentKind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_SpentKind.BackColor = System.Drawing.Color.White;
            this.T_SpentKind.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_SpentKind.ForeColor = System.Drawing.Color.Blue;
            this.T_SpentKind.Location = new System.Drawing.Point(173, 34);
            this.T_SpentKind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_SpentKind.Name = "T_SpentKind";
            this.T_SpentKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_SpentKind.Size = new System.Drawing.Size(253, 31);
            this.T_SpentKind.TabIndex = 0;
            this.T_SpentKind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_SpentKind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SpentKind_KeyDown);
            // 
            // T_HijriDate
            // 
            this.T_HijriDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_HijriDate.BackColor = System.Drawing.Color.White;
            this.T_HijriDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_HijriDate.Location = new System.Drawing.Point(311, 90);
            this.T_HijriDate.Multiline = true;
            this.T_HijriDate.Name = "T_HijriDate";
            this.T_HijriDate.ReadOnly = true;
            this.T_HijriDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_HijriDate.Size = new System.Drawing.Size(115, 29);
            this.T_HijriDate.TabIndex = 1469;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1481;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Spents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(472, 350);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_SAVE);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.btn_ERASE);
            this.Controls.Add(this.DTM_Spent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.T_SpentPrice);
            this.Controls.Add(this.T_Name);
            this.Controls.Add(this.T_SpentKind);
            this.Controls.Add(this.T_HijriDate);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Spents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المصروفات";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Spents_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button btn_SAVE;
        public System.Windows.Forms.Button btn_EXIT;
        public System.Windows.Forms.Button btn_ERASE;
        public System.Windows.Forms.DateTimePicker DTM_Spent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox T_SpentPrice;
        public System.Windows.Forms.TextBox T_Name;
        public System.Windows.Forms.TextBox T_SpentKind;
        private System.Windows.Forms.TextBox T_HijriDate;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}