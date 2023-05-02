namespace MobileShop2023.PL
{
    partial class Form_Sales_SHOW1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sales_SHOW1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.T_InvoiceNo = new System.Windows.Forms.TextBox();
            this.btnPr = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.bntFirst = new System.Windows.Forms.Button();
            this.btn_DELET = new System.Windows.Forms.Button();
            this.btn_EXIT = new System.Windows.Forms.Button();
            this.PrintAll = new System.Windows.Forms.Button();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.T_Total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.T_QuantityRES = new System.Windows.Forms.TextBox();
            this.T_TotQuantity = new System.Windows.Forms.TextBox();
            this.T_QuantitySales = new System.Windows.Forms.TextBox();
            this.T_id = new System.Windows.Forms.TextBox();
            this.T_Code_Catg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.T_HijriDate = new System.Windows.Forms.TextBox();
            this.DTM_Sale = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T_Discount = new System.Windows.Forms.TextBox();
            this.T_VatValue = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.T_Vatpercent = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.T_idCATGS = new System.Windows.Forms.TextBox();
            this.T_ArabicWords = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // T_InvoiceNo
            // 
            this.T_InvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_InvoiceNo.BackColor = System.Drawing.Color.White;
            this.T_InvoiceNo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_InvoiceNo.ForeColor = System.Drawing.Color.DarkRed;
            this.T_InvoiceNo.Location = new System.Drawing.Point(208, 27);
            this.T_InvoiceNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_InvoiceNo.Multiline = true;
            this.T_InvoiceNo.Name = "T_InvoiceNo";
            this.T_InvoiceNo.ReadOnly = true;
            this.T_InvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_InvoiceNo.Size = new System.Drawing.Size(272, 69);
            this.T_InvoiceNo.TabIndex = 1573;
            this.T_InvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPr
            // 
            this.btnPr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPr.Image = ((System.Drawing.Image)(resources.GetObject("btnPr.Image")));
            this.btnPr.Location = new System.Drawing.Point(430, 535);
            this.btnPr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPr.Name = "btnPr";
            this.btnPr.Size = new System.Drawing.Size(50, 42);
            this.btnPr.TabIndex = 1561;
            this.btnPr.UseVisualStyleBackColor = false;
            this.btnPr.Click += new System.EventHandler(this.btnPr_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(701, 535);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 42);
            this.btnNext.TabIndex = 1562;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // position
            // 
            this.position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.position.BackColor = System.Drawing.Color.Cornsilk;
            this.position.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.position.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.position.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(479, 535);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(225, 41);
            this.position.TabIndex = 1559;
            this.position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLast.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(747, 535);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 42);
            this.btnLast.TabIndex = 1563;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // bntFirst
            // 
            this.bntFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntFirst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntFirst.Image = ((System.Drawing.Image)(resources.GetObject("bntFirst.Image")));
            this.bntFirst.Location = new System.Drawing.Point(381, 535);
            this.bntFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntFirst.Name = "bntFirst";
            this.bntFirst.Size = new System.Drawing.Size(50, 42);
            this.bntFirst.TabIndex = 1560;
            this.bntFirst.UseVisualStyleBackColor = false;
            this.bntFirst.Click += new System.EventHandler(this.bntFirst_Click);
            // 
            // btn_DELET
            // 
            this.btn_DELET.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DELET.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DELET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DELET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DELET.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DELET.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_DELET.Image = ((System.Drawing.Image)(resources.GetObject("btn_DELET.Image")));
            this.btn_DELET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DELET.Location = new System.Drawing.Point(381, 576);
            this.btn_DELET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DELET.Name = "btn_DELET";
            this.btn_DELET.Size = new System.Drawing.Size(188, 71);
            this.btn_DELET.TabIndex = 1557;
            this.btn_DELET.Text = "حذف";
            this.btn_DELET.UseVisualStyleBackColor = false;
            this.btn_DELET.Click += new System.EventHandler(this.btn_DELET_Click);
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
            this.btn_EXIT.Location = new System.Drawing.Point(567, 576);
            this.btn_EXIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(230, 71);
            this.btn_EXIT.TabIndex = 1556;
            this.btn_EXIT.Text = "خروج";
            this.btn_EXIT.UseVisualStyleBackColor = false;
            this.btn_EXIT.Click += new System.EventHandler(this.btn_EXIT_Click);
            // 
            // PrintAll
            // 
            this.PrintAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintAll.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PrintAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrintAll.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrintAll.Image = ((System.Drawing.Image)(resources.GetObject("PrintAll.Image")));
            this.PrintAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintAll.Location = new System.Drawing.Point(69, 535);
            this.PrintAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintAll.Name = "PrintAll";
            this.PrintAll.Size = new System.Drawing.Size(315, 112);
            this.PrintAll.TabIndex = 1558;
            this.PrintAll.Text = "طباعة الفاتورة";
            this.PrintAll.UseVisualStyleBackColor = false;
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            this.dgList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Location = new System.Drawing.Point(14, 105);
            this.dgList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowTemplate.Height = 26;
            this.dgList.Size = new System.Drawing.Size(1342, 422);
            this.dgList.TabIndex = 1552;
            this.dgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellClick);
            this.dgList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellContentClick);
            this.dgList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellEnter);
            // 
            // T_Total
            // 
            this.T_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Total.BackColor = System.Drawing.Color.White;
            this.T_Total.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Total.ForeColor = System.Drawing.Color.Blue;
            this.T_Total.Location = new System.Drawing.Point(799, 574);
            this.T_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Total.Name = "T_Total";
            this.T_Total.ReadOnly = true;
            this.T_Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Total.Size = new System.Drawing.Size(502, 42);
            this.T_Total.TabIndex = 1572;
            this.T_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(799, 535);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(502, 41);
            this.label3.TabIndex = 1571;
            this.label3.Text = "إجمالي الفاتورة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1136, 406);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 1577;
            this.button1.Text = "تحديث";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T_QuantityRES
            // 
            this.T_QuantityRES.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_QuantityRES.BackColor = System.Drawing.Color.White;
            this.T_QuantityRES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_QuantityRES.ForeColor = System.Drawing.Color.Blue;
            this.T_QuantityRES.Location = new System.Drawing.Point(1136, 375);
            this.T_QuantityRES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_QuantityRES.Name = "T_QuantityRES";
            this.T_QuantityRES.ReadOnly = true;
            this.T_QuantityRES.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_QuantityRES.Size = new System.Drawing.Size(103, 30);
            this.T_QuantityRES.TabIndex = 1576;
            this.T_QuantityRES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_TotQuantity
            // 
            this.T_TotQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_TotQuantity.BackColor = System.Drawing.Color.White;
            this.T_TotQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_TotQuantity.ForeColor = System.Drawing.Color.Black;
            this.T_TotQuantity.Location = new System.Drawing.Point(1029, 407);
            this.T_TotQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_TotQuantity.Name = "T_TotQuantity";
            this.T_TotQuantity.ReadOnly = true;
            this.T_TotQuantity.Size = new System.Drawing.Size(105, 30);
            this.T_TotQuantity.TabIndex = 1575;
            this.T_TotQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_QuantitySales
            // 
            this.T_QuantitySales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_QuantitySales.BackColor = System.Drawing.Color.White;
            this.T_QuantitySales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_QuantitySales.ForeColor = System.Drawing.Color.Black;
            this.T_QuantitySales.Location = new System.Drawing.Point(1029, 375);
            this.T_QuantitySales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_QuantitySales.Name = "T_QuantitySales";
            this.T_QuantitySales.ReadOnly = true;
            this.T_QuantitySales.Size = new System.Drawing.Size(105, 30);
            this.T_QuantitySales.TabIndex = 1574;
            this.T_QuantitySales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_id
            // 
            this.T_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_id.BackColor = System.Drawing.Color.White;
            this.T_id.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_id.ForeColor = System.Drawing.Color.Black;
            this.T_id.Location = new System.Drawing.Point(744, 406);
            this.T_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_id.Name = "T_id";
            this.T_id.ReadOnly = true;
            this.T_id.Size = new System.Drawing.Size(266, 34);
            this.T_id.TabIndex = 1566;
            this.T_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_Code_Catg
            // 
            this.T_Code_Catg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Code_Catg.BackColor = System.Drawing.Color.White;
            this.T_Code_Catg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Code_Catg.ForeColor = System.Drawing.Color.Black;
            this.T_Code_Catg.Location = new System.Drawing.Point(586, 319);
            this.T_Code_Catg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Code_Catg.Name = "T_Code_Catg";
            this.T_Code_Catg.ReadOnly = true;
            this.T_Code_Catg.Size = new System.Drawing.Size(199, 34);
            this.T_Code_Catg.TabIndex = 1578;
            this.T_Code_Catg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.Crimson;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 70);
            this.label11.TabIndex = 1581;
            this.label11.Text = "رقم الفاتورة";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_HijriDate
            // 
            this.T_HijriDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_HijriDate.BackColor = System.Drawing.Color.White;
            this.T_HijriDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_HijriDate.Location = new System.Drawing.Point(674, 62);
            this.T_HijriDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.T_HijriDate.Multiline = true;
            this.T_HijriDate.Name = "T_HijriDate";
            this.T_HijriDate.ReadOnly = true;
            this.T_HijriDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_HijriDate.Size = new System.Drawing.Size(164, 35);
            this.T_HijriDate.TabIndex = 1582;
            // 
            // DTM_Sale
            // 
            this.DTM_Sale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTM_Sale.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTM_Sale.CausesValidation = false;
            this.DTM_Sale.Checked = false;
            this.DTM_Sale.CustomFormat = "yyyy-MM-dd";
            this.DTM_Sale.Enabled = false;
            this.DTM_Sale.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTM_Sale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTM_Sale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTM_Sale.Location = new System.Drawing.Point(482, 62);
            this.DTM_Sale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTM_Sale.Name = "DTM_Sale";
            this.DTM_Sale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DTM_Sale.RightToLeftLayout = true;
            this.DTM_Sale.Size = new System.Drawing.Size(193, 35);
            this.DTM_Sale.TabIndex = 1583;
            this.DTM_Sale.Value = new System.DateTime(2014, 5, 4, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(482, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(357, 35);
            this.label14.TabIndex = 1584;
            this.label14.Text = "تاريخ الفاتورة";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(840, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 35);
            this.label2.TabIndex = 1590;
            this.label2.Text = "الخصم";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Discount
            // 
            this.T_Discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Discount.BackColor = System.Drawing.Color.White;
            this.T_Discount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Discount.ForeColor = System.Drawing.Color.Blue;
            this.T_Discount.Location = new System.Drawing.Point(840, 62);
            this.T_Discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Discount.Name = "T_Discount";
            this.T_Discount.ReadOnly = true;
            this.T_Discount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Discount.Size = new System.Drawing.Size(122, 34);
            this.T_Discount.TabIndex = 1585;
            this.T_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_VatValue
            // 
            this.T_VatValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_VatValue.BackColor = System.Drawing.Color.White;
            this.T_VatValue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_VatValue.ForeColor = System.Drawing.Color.Blue;
            this.T_VatValue.Location = new System.Drawing.Point(1093, 62);
            this.T_VatValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_VatValue.Name = "T_VatValue";
            this.T_VatValue.ReadOnly = true;
            this.T_VatValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_VatValue.Size = new System.Drawing.Size(262, 34);
            this.T_VatValue.TabIndex = 1589;
            this.T_VatValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(964, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(392, 35);
            this.label16.TabIndex = 1588;
            this.label16.Text = "الضريبة المضافة";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(1059, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 35);
            this.label15.TabIndex = 1587;
            this.label15.Text = "%";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Vatpercent
            // 
            this.T_Vatpercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Vatpercent.BackColor = System.Drawing.Color.White;
            this.T_Vatpercent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Vatpercent.ForeColor = System.Drawing.Color.Blue;
            this.T_Vatpercent.Location = new System.Drawing.Point(964, 62);
            this.T_Vatpercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Vatpercent.Name = "T_Vatpercent";
            this.T_Vatpercent.ReadOnly = true;
            this.T_Vatpercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Vatpercent.Size = new System.Drawing.Size(96, 34);
            this.T_Vatpercent.TabIndex = 1586;
            this.T_Vatpercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 673);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1591;
            this.pictureBox1.TabStop = false;
            // 
            // T_idCATGS
            // 
            this.T_idCATGS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_idCATGS.BackColor = System.Drawing.Color.White;
            this.T_idCATGS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_idCATGS.ForeColor = System.Drawing.Color.Black;
            this.T_idCATGS.Location = new System.Drawing.Point(747, 369);
            this.T_idCATGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_idCATGS.Name = "T_idCATGS";
            this.T_idCATGS.ReadOnly = true;
            this.T_idCATGS.Size = new System.Drawing.Size(264, 34);
            this.T_idCATGS.TabIndex = 1592;
            this.T_idCATGS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_ArabicWords
            // 
            this.T_ArabicWords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_ArabicWords.BackColor = System.Drawing.Color.White;
            this.T_ArabicWords.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_ArabicWords.ForeColor = System.Drawing.Color.Blue;
            this.T_ArabicWords.Location = new System.Drawing.Point(799, 615);
            this.T_ArabicWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_ArabicWords.Multiline = true;
            this.T_ArabicWords.Name = "T_ArabicWords";
            this.T_ArabicWords.ReadOnly = true;
            this.T_ArabicWords.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_ArabicWords.Size = new System.Drawing.Size(502, 35);
            this.T_ArabicWords.TabIndex = 1593;
            this.T_ArabicWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_Sales_SHOW1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 673);
            this.Controls.Add(this.T_ArabicWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T_Discount);
            this.Controls.Add(this.T_VatValue);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.T_Vatpercent);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DTM_Sale);
            this.Controls.Add(this.T_HijriDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.T_InvoiceNo);
            this.Controls.Add(this.btnPr);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.position);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.bntFirst);
            this.Controls.Add(this.btn_DELET);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.PrintAll);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.T_Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.T_Code_Catg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.T_idCATGS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.T_QuantityRES);
            this.Controls.Add(this.T_TotQuantity);
            this.Controls.Add(this.T_QuantitySales);
            this.Controls.Add(this.T_id);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Sales_SHOW1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض المبيعات";
            this.Load += new System.EventHandler(this.Form_Sales_SHOW1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Sales_SHOW1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox T_InvoiceNo;
        public System.Windows.Forms.Button btnPr;
        public System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.Label position;
        public System.Windows.Forms.Button btnLast;
        public System.Windows.Forms.Button bntFirst;
        public System.Windows.Forms.Button btn_DELET;
        public System.Windows.Forms.Button btn_EXIT;
        public System.Windows.Forms.Button PrintAll;
        public System.Windows.Forms.DataGridView dgList;
        public System.Windows.Forms.TextBox T_Total;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox T_QuantityRES;
        public System.Windows.Forms.TextBox T_TotQuantity;
        public System.Windows.Forms.TextBox T_QuantitySales;
        public System.Windows.Forms.TextBox T_id;
        public System.Windows.Forms.TextBox T_Code_Catg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox T_HijriDate;
        public System.Windows.Forms.DateTimePicker DTM_Sale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox T_Discount;
        public System.Windows.Forms.TextBox T_VatValue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox T_Vatpercent;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox T_idCATGS;
        public System.Windows.Forms.TextBox T_ArabicWords;
    }
}