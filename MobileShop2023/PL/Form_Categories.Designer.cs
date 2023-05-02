namespace MobileShop2023.PL
{
    partial class Form_Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Categories));
            this.T_HijriDate = new System.Windows.Forms.TextBox();
            this.T_Code_Catg = new System.Windows.Forms.TextBox();
            this.DTM_Purchasing = new System.Windows.Forms.DateTimePicker();
            this.T_CatgName = new System.Windows.Forms.TextBox();
            this.T_Quantity = new System.Windows.Forms.TextBox();
            this.T_purchasing = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.T_Minimum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.T_Sale_Price = new System.Windows.Forms.TextBox();
            this.btn_SAVE = new System.Windows.Forms.Button();
            this.btn_EXIT = new System.Windows.Forms.Button();
            this.btn_ERASE = new System.Windows.Forms.Button();
            this.T_TOTpurchasing = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Scanar = new System.Windows.Forms.Button();
            this.btn_Shose = new System.Windows.Forms.Button();
            this.PBox = new System.Windows.Forms.PictureBox();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // T_HijriDate
            // 
            this.T_HijriDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_HijriDate.BackColor = System.Drawing.Color.White;
            this.T_HijriDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_HijriDate.Location = new System.Drawing.Point(300, 150);
            this.T_HijriDate.Multiline = true;
            this.T_HijriDate.Name = "T_HijriDate";
            this.T_HijriDate.ReadOnly = true;
            this.T_HijriDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_HijriDate.Size = new System.Drawing.Size(115, 29);
            this.T_HijriDate.TabIndex = 1426;
            // 
            // T_Code_Catg
            // 
            this.T_Code_Catg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Code_Catg.BackColor = System.Drawing.Color.White;
            this.T_Code_Catg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Code_Catg.ForeColor = System.Drawing.Color.Black;
            this.T_Code_Catg.Location = new System.Drawing.Point(160, 38);
            this.T_Code_Catg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Code_Catg.Name = "T_Code_Catg";
            this.T_Code_Catg.Size = new System.Drawing.Size(255, 31);
            this.T_Code_Catg.TabIndex = 0;
            this.T_Code_Catg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Code_Catg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_Code_Catg_KeyDown);
            this.T_Code_Catg.Validated += new System.EventHandler(this.T_Code_Catg_Validated);
            // 
            // DTM_Purchasing
            // 
            this.DTM_Purchasing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTM_Purchasing.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTM_Purchasing.CausesValidation = false;
            this.DTM_Purchasing.Checked = false;
            this.DTM_Purchasing.CustomFormat = "yyyy-MM-dd";
            this.DTM_Purchasing.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTM_Purchasing.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTM_Purchasing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTM_Purchasing.Location = new System.Drawing.Point(162, 150);
            this.DTM_Purchasing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTM_Purchasing.Name = "DTM_Purchasing";
            this.DTM_Purchasing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DTM_Purchasing.RightToLeftLayout = true;
            this.DTM_Purchasing.Size = new System.Drawing.Size(140, 29);
            this.DTM_Purchasing.TabIndex = 7;
            this.DTM_Purchasing.Value = new System.DateTime(2014, 5, 4, 0, 0, 0, 0);
            this.DTM_Purchasing.ValueChanged += new System.EventHandler(this.DTM_Purchasing_ValueChanged);
            this.DTM_Purchasing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_Code_Catg_KeyDown);
            // 
            // T_CatgName
            // 
            this.T_CatgName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_CatgName.BackColor = System.Drawing.Color.White;
            this.T_CatgName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_CatgName.ForeColor = System.Drawing.Color.Blue;
            this.T_CatgName.Location = new System.Drawing.Point(162, 66);
            this.T_CatgName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_CatgName.Name = "T_CatgName";
            this.T_CatgName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_CatgName.Size = new System.Drawing.Size(253, 31);
            this.T_CatgName.TabIndex = 1;
            this.T_CatgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_CatgName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_Code_Catg_KeyDown);
            // 
            // T_Quantity
            // 
            this.T_Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Quantity.BackColor = System.Drawing.Color.White;
            this.T_Quantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Quantity.ForeColor = System.Drawing.Color.Blue;
            this.T_Quantity.Location = new System.Drawing.Point(162, 94);
            this.T_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Quantity.Name = "T_Quantity";
            this.T_Quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Quantity.Size = new System.Drawing.Size(253, 31);
            this.T_Quantity.TabIndex = 3;
            this.T_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Quantity.TextChanged += new System.EventHandler(this.T_Quantity_TextChanged);
            this.T_Quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_Code_Catg_KeyDown);
            this.T_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Quantity_KeyPress);
            // 
            // T_purchasing
            // 
            this.T_purchasing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_purchasing.BackColor = System.Drawing.Color.White;
            this.T_purchasing.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_purchasing.ForeColor = System.Drawing.Color.Blue;
            this.T_purchasing.Location = new System.Drawing.Point(160, 122);
            this.T_purchasing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_purchasing.Name = "T_purchasing";
            this.T_purchasing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_purchasing.Size = new System.Drawing.Size(255, 31);
            this.T_purchasing.TabIndex = 5;
            this.T_purchasing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_purchasing.TextChanged += new System.EventHandler(this.T_purchasing_TextChanged);
            this.T_purchasing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_Code_Catg_KeyDown);
            this.T_purchasing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_purchasing_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(36, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 29);
            this.label9.TabIndex = 1438;
            this.label9.Text = "اسم الصنف";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(36, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 29);
            this.label11.TabIndex = 1440;
            this.label11.Text = "الكمية";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(36, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 29);
            this.label12.TabIndex = 1441;
            this.label12.Text = "سعر الشراء الإفرادي";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(36, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 29);
            this.label14.TabIndex = 1443;
            this.label14.Text = "تاريخ الشراء";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.BackColor = System.Drawing.Color.Crimson;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(36, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 29);
            this.label20.TabIndex = 1446;
            this.label20.Text = "أدخل رقم الصنف";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 1448;
            this.label1.Text = "الحد الأدنى للطلب";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Minimum
            // 
            this.T_Minimum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Minimum.BackColor = System.Drawing.Color.White;
            this.T_Minimum.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Minimum.ForeColor = System.Drawing.Color.Blue;
            this.T_Minimum.Location = new System.Drawing.Point(159, 204);
            this.T_Minimum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Minimum.Name = "T_Minimum";
            this.T_Minimum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Minimum.Size = new System.Drawing.Size(201, 31);
            this.T_Minimum.TabIndex = 4;
            this.T_Minimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Minimum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_Code_Catg_KeyDown);
            this.T_Minimum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Minimum_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 1449;
            this.label2.Text = "سعر البيع الإفرادي";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Sale_Price
            // 
            this.T_Sale_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Sale_Price.BackColor = System.Drawing.Color.White;
            this.T_Sale_Price.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Sale_Price.ForeColor = System.Drawing.Color.Blue;
            this.T_Sale_Price.Location = new System.Drawing.Point(162, 177);
            this.T_Sale_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Sale_Price.Name = "T_Sale_Price";
            this.T_Sale_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Sale_Price.Size = new System.Drawing.Size(253, 31);
            this.T_Sale_Price.TabIndex = 8;
            this.T_Sale_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Sale_Price.TextChanged += new System.EventHandler(this.T_Sale_Price_TextChanged);
            this.T_Sale_Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_Code_Catg_KeyDown);
            this.T_Sale_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Sale_Price_KeyPress);
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SAVE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SAVE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SAVE.Image = ((System.Drawing.Image)(resources.GetObject("btn_SAVE.Image")));
            this.btn_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SAVE.Location = new System.Drawing.Point(54, 308);
            this.btn_SAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SAVE.Name = "btn_SAVE";
            this.btn_SAVE.Size = new System.Drawing.Size(165, 45);
            this.btn_SAVE.TabIndex = 9;
            this.btn_SAVE.Text = "حفظ";
            this.btn_SAVE.UseVisualStyleBackColor = false;
            this.btn_SAVE.Click += new System.EventHandler(this.btn_SAVE_Click);
            this.btn_SAVE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_Code_Catg_KeyDown);
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EXIT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_EXIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EXIT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EXIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("btn_EXIT.Image")));
            this.btn_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EXIT.Location = new System.Drawing.Point(54, 353);
            this.btn_EXIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(323, 45);
            this.btn_EXIT.TabIndex = 1456;
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
            this.btn_ERASE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ERASE.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ERASE.Image = ((System.Drawing.Image)(resources.GetObject("btn_ERASE.Image")));
            this.btn_ERASE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ERASE.Location = new System.Drawing.Point(217, 308);
            this.btn_ERASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ERASE.Name = "btn_ERASE";
            this.btn_ERASE.Size = new System.Drawing.Size(160, 45);
            this.btn_ERASE.TabIndex = 1455;
            this.btn_ERASE.Text = "مسح";
            this.btn_ERASE.UseVisualStyleBackColor = false;
            this.btn_ERASE.Click += new System.EventHandler(this.btn_ERASE_Click);
            // 
            // T_TOTpurchasing
            // 
            this.T_TOTpurchasing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_TOTpurchasing.BackColor = System.Drawing.Color.White;
            this.T_TOTpurchasing.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_TOTpurchasing.ForeColor = System.Drawing.Color.Blue;
            this.T_TOTpurchasing.Location = new System.Drawing.Point(162, 231);
            this.T_TOTpurchasing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_TOTpurchasing.Name = "T_TOTpurchasing";
            this.T_TOTpurchasing.ReadOnly = true;
            this.T_TOTpurchasing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_TOTpurchasing.Size = new System.Drawing.Size(253, 31);
            this.T_TOTpurchasing.TabIndex = 1459;
            this.T_TOTpurchasing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.BackColor = System.Drawing.Color.SteelBlue;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(460, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(251, 31);
            this.label19.TabIndex = 1464;
            this.label19.Text = "صورة الصنف";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Scanar
            // 
            this.btn_Scanar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Scanar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Scanar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Scanar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Scanar.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Scanar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Scanar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Scanar.Image")));
            this.btn_Scanar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Scanar.Location = new System.Drawing.Point(460, 352);
            this.btn_Scanar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Scanar.Name = "btn_Scanar";
            this.btn_Scanar.Size = new System.Drawing.Size(250, 45);
            this.btn_Scanar.TabIndex = 1467;
            this.btn_Scanar.Text = "ماسح ضوئي";
            this.btn_Scanar.UseVisualStyleBackColor = false;
            this.btn_Scanar.Click += new System.EventHandler(this.btn_Scanar_Click);
            // 
            // btn_Shose
            // 
            this.btn_Shose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Shose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Shose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shose.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shose.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Shose.Image = ((System.Drawing.Image)(resources.GetObject("btn_Shose.Image")));
            this.btn_Shose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Shose.Location = new System.Drawing.Point(460, 308);
            this.btn_Shose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Shose.Name = "btn_Shose";
            this.btn_Shose.Size = new System.Drawing.Size(250, 45);
            this.btn_Shose.TabIndex = 1465;
            this.btn_Shose.Text = "حدد الصورة";
            this.btn_Shose.UseVisualStyleBackColor = false;
            this.btn_Shose.Click += new System.EventHandler(this.btn_Shose_Click);
            // 
            // PBox
            // 
            this.PBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBox.Image = ((System.Drawing.Image)(resources.GetObject("PBox.Image")));
            this.PBox.Location = new System.Drawing.Point(460, 66);
            this.PBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(251, 242);
            this.PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBox.TabIndex = 1466;
            this.PBox.TabStop = false;
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(533, 291);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(144, 30);
            this.lbDevices.TabIndex = 1468;
            this.lbDevices.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(747, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1458;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 1469;
            this.label3.Text = "إجمالي المشتريات";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(747, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Scanar);
            this.Controls.Add(this.btn_Shose);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_SAVE);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.btn_ERASE);
            this.Controls.Add(this.T_Sale_Price);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.DTM_Purchasing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_Minimum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.T_purchasing);
            this.Controls.Add(this.T_Quantity);
            this.Controls.Add(this.T_CatgName);
            this.Controls.Add(this.T_HijriDate);
            this.Controls.Add(this.T_Code_Catg);
            this.Controls.Add(this.T_TOTpurchasing);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Categories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأصناف";
            this.Load += new System.EventHandler(this.Form_Categories_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Categories_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox T_HijriDate;
        public System.Windows.Forms.TextBox T_Code_Catg;
        public System.Windows.Forms.DateTimePicker DTM_Purchasing;
        public System.Windows.Forms.TextBox T_CatgName;
        public System.Windows.Forms.TextBox T_Quantity;
        public System.Windows.Forms.TextBox T_purchasing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox T_Minimum;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox T_Sale_Price;
        public System.Windows.Forms.Button btn_SAVE;
        public System.Windows.Forms.Button btn_EXIT;
        public System.Windows.Forms.Button btn_ERASE;
        public System.Windows.Forms.TextBox T_TOTpurchasing;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.Button btn_Scanar;
        public System.Windows.Forms.Button btn_Shose;
        public System.Windows.Forms.PictureBox PBox;
        public System.Windows.Forms.ListBox lbDevices;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}