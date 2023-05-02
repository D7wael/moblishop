namespace MobileShop2023.PL
{
    partial class Form_Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label20 = new System.Windows.Forms.Label();
            this.T_Code_Catg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.T_InvoiceNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.T_SalerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.T_CustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.T_Phone = new System.Windows.Forms.TextBox();
            this.T_PaymentMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.T_CatgName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.T_QuantityCurrent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.T_QuantitySales = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DTM_Sale = new System.Windows.Forms.DateTimePicker();
            this.T_HijriDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.T_Sale_Price = new System.Windows.Forms.TextBox();
            this.T_VatValue = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.T_Vatpercent = new System.Windows.Forms.TextBox();
            this.T_Sale_Total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.T_Discount = new System.Windows.Forms.TextBox();
            this.T_AllTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.T_QuantityRES = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_SAVE = new System.Windows.Forms.Button();
            this.btn_EXIT = new System.Windows.Forms.Button();
            this.btn_ERASE = new System.Windows.Forms.Button();
            this.PrintINVC = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.T_Paid = new System.Windows.Forms.TextBox();
            this.T_Res = new System.Windows.Forms.TextBox();
            this.T_ArabicWords = new System.Windows.Forms.TextBox();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.T_total1 = new System.Windows.Forms.TextBox();
            this.btn_DELET = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.T_idCAT = new System.Windows.Forms.TextBox();
            this.T_purchasing = new System.Windows.Forms.TextBox();
            this.T_purchasingTOT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.BackColor = System.Drawing.Color.Crimson;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(30, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 28);
            this.label20.TabIndex = 1460;
            this.label20.Text = "أدخل رقم الصنف";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // T_Code_Catg
            // 
            this.T_Code_Catg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Code_Catg.BackColor = System.Drawing.Color.White;
            this.T_Code_Catg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Code_Catg.ForeColor = System.Drawing.Color.Black;
            this.T_Code_Catg.Location = new System.Drawing.Point(153, 102);
            this.T_Code_Catg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Code_Catg.Name = "T_Code_Catg";
            this.T_Code_Catg.Size = new System.Drawing.Size(260, 31);
            this.T_Code_Catg.TabIndex = 4;
            this.T_Code_Catg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Code_Catg.TextChanged += new System.EventHandler(this.T_Code_Catg_TextChanged);
            this.T_Code_Catg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.Crimson;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(336, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 48);
            this.label11.TabIndex = 1462;
            this.label11.Text = "رقم الفاتورة";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_InvoiceNo
            // 
            this.T_InvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_InvoiceNo.BackColor = System.Drawing.Color.White;
            this.T_InvoiceNo.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_InvoiceNo.ForeColor = System.Drawing.Color.DarkRed;
            this.T_InvoiceNo.Location = new System.Drawing.Point(486, 10);
            this.T_InvoiceNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_InvoiceNo.Multiline = true;
            this.T_InvoiceNo.Name = "T_InvoiceNo";
            this.T_InvoiceNo.ReadOnly = true;
            this.T_InvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_InvoiceNo.Size = new System.Drawing.Size(363, 48);
            this.T_InvoiceNo.TabIndex = 1461;
            this.T_InvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 1464;
            this.label1.Text = "اسم البائع";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_SalerName
            // 
            this.T_SalerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_SalerName.BackColor = System.Drawing.Color.White;
            this.T_SalerName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_SalerName.ForeColor = System.Drawing.Color.Blue;
            this.T_SalerName.Location = new System.Drawing.Point(157, 184);
            this.T_SalerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_SalerName.Name = "T_SalerName";
            this.T_SalerName.ReadOnly = true;
            this.T_SalerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_SalerName.Size = new System.Drawing.Size(382, 31);
            this.T_SalerName.TabIndex = 0;
            this.T_SalerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_SalerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 1466;
            this.label2.Text = "اسم العميل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_CustomerName
            // 
            this.T_CustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_CustomerName.BackColor = System.Drawing.Color.White;
            this.T_CustomerName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_CustomerName.ForeColor = System.Drawing.Color.Black;
            this.T_CustomerName.Location = new System.Drawing.Point(156, 64);
            this.T_CustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_CustomerName.Name = "T_CustomerName";
            this.T_CustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_CustomerName.Size = new System.Drawing.Size(250, 31);
            this.T_CustomerName.TabIndex = 1;
            this.T_CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_CustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(407, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 1468;
            this.label3.Text = "رقم الجوال";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Phone
            // 
            this.T_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Phone.BackColor = System.Drawing.Color.White;
            this.T_Phone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Phone.ForeColor = System.Drawing.Color.Black;
            this.T_Phone.Location = new System.Drawing.Point(533, 63);
            this.T_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Phone.Name = "T_Phone";
            this.T_Phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Phone.Size = new System.Drawing.Size(173, 31);
            this.T_Phone.TabIndex = 2;
            this.T_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            this.T_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Phone_KeyPress);
            // 
            // T_PaymentMethod
            // 
            this.T_PaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_PaymentMethod.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_PaymentMethod.FormattingEnabled = true;
            this.T_PaymentMethod.ImeMode = System.Windows.Forms.ImeMode.On;
            this.T_PaymentMethod.IntegralHeight = false;
            this.T_PaymentMethod.ItemHeight = 20;
            this.T_PaymentMethod.Items.AddRange(new object[] {
            "نقدي",
            "شبكة",
            "تحويل بنكي"});
            this.T_PaymentMethod.Location = new System.Drawing.Point(830, 63);
            this.T_PaymentMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_PaymentMethod.Name = "T_PaymentMethod";
            this.T_PaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_PaymentMethod.Size = new System.Drawing.Size(200, 28);
            this.T_PaymentMethod.TabIndex = 3;
            this.T_PaymentMethod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(704, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 31);
            this.label4.TabIndex = 1470;
            this.label4.Text = "طريقة الدفع";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(412, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 29);
            this.label9.TabIndex = 1475;
            this.label9.Text = "نوع الصنف";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_CatgName
            // 
            this.T_CatgName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_CatgName.BackColor = System.Drawing.Color.White;
            this.T_CatgName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_CatgName.ForeColor = System.Drawing.Color.Black;
            this.T_CatgName.Location = new System.Drawing.Point(533, 102);
            this.T_CatgName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_CatgName.Name = "T_CatgName";
            this.T_CatgName.ReadOnly = true;
            this.T_CatgName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_CatgName.Size = new System.Drawing.Size(259, 31);
            this.T_CatgName.TabIndex = 1473;
            this.T_CatgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(789, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 1478;
            this.label5.Text = "الكمية الحالية";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_QuantityCurrent
            // 
            this.T_QuantityCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_QuantityCurrent.BackColor = System.Drawing.Color.White;
            this.T_QuantityCurrent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_QuantityCurrent.ForeColor = System.Drawing.Color.Black;
            this.T_QuantityCurrent.Location = new System.Drawing.Point(892, 102);
            this.T_QuantityCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_QuantityCurrent.Name = "T_QuantityCurrent";
            this.T_QuantityCurrent.ReadOnly = true;
            this.T_QuantityCurrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_QuantityCurrent.Size = new System.Drawing.Size(144, 31);
            this.T_QuantityCurrent.TabIndex = 1477;
            this.T_QuantityCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Brown;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 1479;
            this.label6.Text = "كمية البيع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_QuantitySales
            // 
            this.T_QuantitySales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_QuantitySales.BackColor = System.Drawing.Color.White;
            this.T_QuantitySales.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_QuantitySales.ForeColor = System.Drawing.Color.Black;
            this.T_QuantitySales.Location = new System.Drawing.Point(156, 130);
            this.T_QuantitySales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_QuantitySales.Name = "T_QuantitySales";
            this.T_QuantitySales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_QuantitySales.Size = new System.Drawing.Size(257, 31);
            this.T_QuantitySales.TabIndex = 5;
            this.T_QuantitySales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_QuantitySales.TextChanged += new System.EventHandler(this.T_QuantitySales_TextChanged);
            this.T_QuantitySales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            this.T_QuantitySales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_QuantitySales_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(30, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 29);
            this.label14.TabIndex = 1483;
            this.label14.Text = "التاريخ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTM_Sale
            // 
            this.DTM_Sale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTM_Sale.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTM_Sale.CausesValidation = false;
            this.DTM_Sale.Checked = false;
            this.DTM_Sale.CustomFormat = "yyyy-MM-dd";
            this.DTM_Sale.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTM_Sale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTM_Sale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTM_Sale.Location = new System.Drawing.Point(157, 158);
            this.DTM_Sale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTM_Sale.Name = "DTM_Sale";
            this.DTM_Sale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DTM_Sale.RightToLeftLayout = true;
            this.DTM_Sale.Size = new System.Drawing.Size(182, 29);
            this.DTM_Sale.TabIndex = 9;
            this.DTM_Sale.Value = new System.DateTime(2014, 5, 4, 0, 0, 0, 0);
            this.DTM_Sale.ValueChanged += new System.EventHandler(this.DTM_Sale_ValueChanged);
            this.DTM_Sale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            // 
            // T_HijriDate
            // 
            this.T_HijriDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_HijriDate.BackColor = System.Drawing.Color.White;
            this.T_HijriDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_HijriDate.Location = new System.Drawing.Point(336, 158);
            this.T_HijriDate.Multiline = true;
            this.T_HijriDate.Name = "T_HijriDate";
            this.T_HijriDate.ReadOnly = true;
            this.T_HijriDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_HijriDate.Size = new System.Drawing.Size(203, 29);
            this.T_HijriDate.TabIndex = 1482;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(412, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 30);
            this.label7.TabIndex = 1485;
            this.label7.Text = "السعر الإفرادي";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Sale_Price
            // 
            this.T_Sale_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Sale_Price.BackColor = System.Drawing.Color.White;
            this.T_Sale_Price.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Sale_Price.ForeColor = System.Drawing.Color.Black;
            this.T_Sale_Price.Location = new System.Drawing.Point(533, 131);
            this.T_Sale_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Sale_Price.Name = "T_Sale_Price";
            this.T_Sale_Price.ReadOnly = true;
            this.T_Sale_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Sale_Price.Size = new System.Drawing.Size(193, 31);
            this.T_Sale_Price.TabIndex = 6;
            this.T_Sale_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Sale_Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            this.T_Sale_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Sale_Price_KeyPress);
            // 
            // T_VatValue
            // 
            this.T_VatValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_VatValue.BackColor = System.Drawing.Color.White;
            this.T_VatValue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_VatValue.ForeColor = System.Drawing.Color.Blue;
            this.T_VatValue.Location = new System.Drawing.Point(306, 434);
            this.T_VatValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_VatValue.Name = "T_VatValue";
            this.T_VatValue.ReadOnly = true;
            this.T_VatValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_VatValue.Size = new System.Drawing.Size(100, 31);
            this.T_VatValue.TabIndex = 1489;
            this.T_VatValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(122, 434);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 31);
            this.label16.TabIndex = 1488;
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
            this.label15.Location = new System.Drawing.Point(277, 434);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 31);
            this.label15.TabIndex = 1487;
            this.label15.Text = "%";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Vatpercent
            // 
            this.T_Vatpercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Vatpercent.BackColor = System.Drawing.Color.White;
            this.T_Vatpercent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Vatpercent.ForeColor = System.Drawing.Color.Blue;
            this.T_Vatpercent.Location = new System.Drawing.Point(233, 434);
            this.T_Vatpercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Vatpercent.Name = "T_Vatpercent";
            this.T_Vatpercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Vatpercent.Size = new System.Drawing.Size(45, 31);
            this.T_Vatpercent.TabIndex = 8;
            this.T_Vatpercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Vatpercent.TextChanged += new System.EventHandler(this.T_Vatpercent_TextChanged);
            this.T_Vatpercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            this.T_Vatpercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Vatpercent_KeyPress);
            // 
            // T_Sale_Total
            // 
            this.T_Sale_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Sale_Total.BackColor = System.Drawing.Color.White;
            this.T_Sale_Total.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Sale_Total.ForeColor = System.Drawing.Color.Black;
            this.T_Sale_Total.Location = new System.Drawing.Point(830, 131);
            this.T_Sale_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Sale_Total.Name = "T_Sale_Total";
            this.T_Sale_Total.ReadOnly = true;
            this.T_Sale_Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Sale_Total.Size = new System.Drawing.Size(206, 31);
            this.T_Sale_Total.TabIndex = 1491;
            this.T_Sale_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Sale_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Sale_Total_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(728, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 28);
            this.label8.TabIndex = 1490;
            this.label8.Text = "السعر الإجمالي";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.BackColor = System.Drawing.Color.Brown;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(10, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 31);
            this.label12.TabIndex = 1493;
            this.label12.Text = "الخصم";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Discount
            // 
            this.T_Discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Discount.BackColor = System.Drawing.Color.White;
            this.T_Discount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Discount.ForeColor = System.Drawing.Color.Blue;
            this.T_Discount.Location = new System.Drawing.Point(65, 434);
            this.T_Discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Discount.Name = "T_Discount";
            this.T_Discount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_Discount.Size = new System.Drawing.Size(58, 31);
            this.T_Discount.TabIndex = 7;
            this.T_Discount.Text = "0";
            this.T_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Discount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            this.T_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Discount_KeyPress);
            // 
            // T_AllTotal
            // 
            this.T_AllTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_AllTotal.BackColor = System.Drawing.Color.White;
            this.T_AllTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_AllTotal.ForeColor = System.Drawing.Color.Blue;
            this.T_AllTotal.Location = new System.Drawing.Point(468, 434);
            this.T_AllTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_AllTotal.Name = "T_AllTotal";
            this.T_AllTotal.ReadOnly = true;
            this.T_AllTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_AllTotal.Size = new System.Drawing.Size(166, 31);
            this.T_AllTotal.TabIndex = 1495;
            this.T_AllTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(405, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 31);
            this.label13.TabIndex = 1494;
            this.label13.Text = "المجموع";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_QuantityRES
            // 
            this.T_QuantityRES.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_QuantityRES.BackColor = System.Drawing.Color.White;
            this.T_QuantityRES.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_QuantityRES.ForeColor = System.Drawing.Color.Blue;
            this.T_QuantityRES.Location = new System.Drawing.Point(830, 157);
            this.T_QuantityRES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_QuantityRES.Name = "T_QuantityRES";
            this.T_QuantityRES.ReadOnly = true;
            this.T_QuantityRES.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_QuantityRES.Size = new System.Drawing.Size(206, 31);
            this.T_QuantityRES.TabIndex = 1497;
            this.T_QuantityRES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.BackColor = System.Drawing.Color.BurlyWood;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(538, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(293, 30);
            this.label17.TabIndex = 1496;
            this.label17.Text = "كمية المخزون المتبقية";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_New.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_New.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.Image")));
            this.btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_New.Location = new System.Drawing.Point(156, 10);
            this.btn_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(183, 48);
            this.btn_New.TabIndex = 1502;
            this.btn_New.Text = "إضافة فاتورة";
            this.btn_New.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SAVE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SAVE.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SAVE.Image = ((System.Drawing.Image)(resources.GetObject("btn_SAVE.Image")));
            this.btn_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SAVE.Location = new System.Drawing.Point(136, 476);
            this.btn_SAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SAVE.Name = "btn_SAVE";
            this.btn_SAVE.Size = new System.Drawing.Size(159, 55);
            this.btn_SAVE.TabIndex = 11;
            this.btn_SAVE.Text = "حفظ";
            this.btn_SAVE.UseVisualStyleBackColor = false;
            this.btn_SAVE.Click += new System.EventHandler(this.btn_SAVE_Click);
            this.btn_SAVE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_SalerName_KeyDown);
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EXIT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_EXIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EXIT.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EXIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("btn_EXIT.Image")));
            this.btn_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EXIT.Location = new System.Drawing.Point(767, 476);
            this.btn_EXIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(159, 55);
            this.btn_EXIT.TabIndex = 1505;
            this.btn_EXIT.Text = "خروج";
            this.btn_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btn_ERASE.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ERASE.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ERASE.Image = ((System.Drawing.Image)(resources.GetObject("btn_ERASE.Image")));
            this.btn_ERASE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ERASE.Location = new System.Drawing.Point(610, 476);
            this.btn_ERASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ERASE.Name = "btn_ERASE";
            this.btn_ERASE.Size = new System.Drawing.Size(159, 55);
            this.btn_ERASE.TabIndex = 1504;
            this.btn_ERASE.Text = "مسح";
            this.btn_ERASE.UseVisualStyleBackColor = false;
            this.btn_ERASE.Click += new System.EventHandler(this.btn_ERASE_Click);
            // 
            // PrintINVC
            // 
            this.PrintINVC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintINVC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PrintINVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintINVC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintINVC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrintINVC.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintINVC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrintINVC.Image = ((System.Drawing.Image)(resources.GetObject("PrintINVC.Image")));
            this.PrintINVC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintINVC.Location = new System.Drawing.Point(294, 476);
            this.PrintINVC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintINVC.Name = "PrintINVC";
            this.PrintINVC.Size = new System.Drawing.Size(159, 55);
            this.PrintINVC.TabIndex = 1507;
            this.PrintINVC.Text = "طباعة";
            this.PrintINVC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintINVC.UseVisualStyleBackColor = false;
            this.PrintINVC.Click += new System.EventHandler(this.PrintINVC_Click);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(531, 549);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 19);
            this.label18.TabIndex = 1512;
            this.label18.Text = "المبلغ المتبقي";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(261, 549);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 19);
            this.label19.TabIndex = 1511;
            this.label19.Text = "المبلغ المدفوع";
            // 
            // T_Paid
            // 
            this.T_Paid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Paid.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Paid.Location = new System.Drawing.Point(358, 546);
            this.T_Paid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Paid.Name = "T_Paid";
            this.T_Paid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.T_Paid.Size = new System.Drawing.Size(169, 31);
            this.T_Paid.TabIndex = 1510;
            this.T_Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Paid.TextChanged += new System.EventHandler(this.T_Paid_TextChanged);
            this.T_Paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Paid_KeyPress);
            // 
            // T_Res
            // 
            this.T_Res.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_Res.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Res.Location = new System.Drawing.Point(626, 546);
            this.T_Res.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Res.Name = "T_Res";
            this.T_Res.ReadOnly = true;
            this.T_Res.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.T_Res.Size = new System.Drawing.Size(167, 31);
            this.T_Res.TabIndex = 1509;
            this.T_Res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_ArabicWords
            // 
            this.T_ArabicWords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_ArabicWords.BackColor = System.Drawing.Color.White;
            this.T_ArabicWords.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_ArabicWords.ForeColor = System.Drawing.Color.Blue;
            this.T_ArabicWords.Location = new System.Drawing.Point(633, 435);
            this.T_ArabicWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_ArabicWords.Multiline = true;
            this.T_ArabicWords.Name = "T_ArabicWords";
            this.T_ArabicWords.ReadOnly = true;
            this.T_ArabicWords.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_ArabicWords.Size = new System.Drawing.Size(416, 29);
            this.T_ArabicWords.TabIndex = 1513;
            this.T_ArabicWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dgList.Location = new System.Drawing.Point(10, 257);
            this.dgList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowTemplate.Height = 26;
            this.dgList.Size = new System.Drawing.Size(1043, 150);
            this.dgList.TabIndex = 1516;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(10, 215);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(1043, 42);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "إضافة";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // T_total1
            // 
            this.T_total1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_total1.BackColor = System.Drawing.Color.White;
            this.T_total1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_total1.ForeColor = System.Drawing.Color.Blue;
            this.T_total1.Location = new System.Drawing.Point(633, 406);
            this.T_total1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_total1.Name = "T_total1";
            this.T_total1.ReadOnly = true;
            this.T_total1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_total1.Size = new System.Drawing.Size(417, 31);
            this.T_total1.TabIndex = 1519;
            this.T_total1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_DELET
            // 
            this.btn_DELET.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DELET.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DELET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DELET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DELET.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DELET.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DELET.Image = ((System.Drawing.Image)(resources.GetObject("btn_DELET.Image")));
            this.btn_DELET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DELET.Location = new System.Drawing.Point(452, 476);
            this.btn_DELET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DELET.Name = "btn_DELET";
            this.btn_DELET.Size = new System.Drawing.Size(159, 55);
            this.btn_DELET.TabIndex = 1520;
            this.btn_DELET.Text = "إلغاء صنف";
            this.btn_DELET.UseVisualStyleBackColor = false;
            this.btn_DELET.Click += new System.EventHandler(this.btn_DELET_Click);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.BackColor = System.Drawing.SystemColors.Info;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(10, 406);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(623, 29);
            this.label21.TabIndex = 1521;
            this.label21.Text = "إجمالي الأصناف";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_idCAT
            // 
            this.T_idCAT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_idCAT.BackColor = System.Drawing.Color.White;
            this.T_idCAT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_idCAT.ForeColor = System.Drawing.Color.Black;
            this.T_idCAT.Location = new System.Drawing.Point(864, 21);
            this.T_idCAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_idCAT.Name = "T_idCAT";
            this.T_idCAT.ReadOnly = true;
            this.T_idCAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_idCAT.Size = new System.Drawing.Size(166, 29);
            this.T_idCAT.TabIndex = 1523;
            this.T_idCAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_purchasing
            // 
            this.T_purchasing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_purchasing.BackColor = System.Drawing.Color.White;
            this.T_purchasing.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_purchasing.ForeColor = System.Drawing.Color.Blue;
            this.T_purchasing.Location = new System.Drawing.Point(533, 62);
            this.T_purchasing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_purchasing.Name = "T_purchasing";
            this.T_purchasing.ReadOnly = true;
            this.T_purchasing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_purchasing.Size = new System.Drawing.Size(147, 29);
            this.T_purchasing.TabIndex = 1526;
            this.T_purchasing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_purchasingTOT
            // 
            this.T_purchasingTOT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.T_purchasingTOT.BackColor = System.Drawing.Color.White;
            this.T_purchasingTOT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_purchasingTOT.ForeColor = System.Drawing.Color.Blue;
            this.T_purchasingTOT.Location = new System.Drawing.Point(684, 61);
            this.T_purchasingTOT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_purchasingTOT.Name = "T_purchasingTOT";
            this.T_purchasingTOT.ReadOnly = true;
            this.T_purchasingTOT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_purchasingTOT.Size = new System.Drawing.Size(147, 29);
            this.T_purchasingTOT.TabIndex = 1527;
            this.T_purchasingTOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 591);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1525;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1062, 591);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btn_DELET);
            this.Controls.Add(this.T_total1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.T_Code_Catg);
            this.Controls.Add(this.T_HijriDate);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.T_CatgName);
            this.Controls.Add(this.T_CustomerName);
            this.Controls.Add(this.T_ArabicWords);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.T_Paid);
            this.Controls.Add(this.T_Res);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_ERASE);
            this.Controls.Add(this.PrintINVC);
            this.Controls.Add(this.btn_SAVE);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.T_QuantityRES);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.T_AllTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.T_Discount);
            this.Controls.Add(this.T_Sale_Price);
            this.Controls.Add(this.T_Sale_Total);
            this.Controls.Add(this.T_VatValue);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.T_Vatpercent);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DTM_Sale);
            this.Controls.Add(this.T_QuantitySales);
            this.Controls.Add(this.T_QuantityCurrent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.T_PaymentMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.T_Phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_SalerName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.T_InvoiceNo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.T_idCAT);
            this.Controls.Add(this.T_purchasingTOT);
            this.Controls.Add(this.T_purchasing);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Sales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.Form_Sales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Sales_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox T_Code_Catg;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox T_InvoiceNo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox T_SalerName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox T_CustomerName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox T_Phone;
        public System.Windows.Forms.ComboBox T_PaymentMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox T_CatgName;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox T_QuantityCurrent;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox T_QuantitySales;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DateTimePicker DTM_Sale;
        private System.Windows.Forms.TextBox T_HijriDate;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox T_Sale_Price;
        public System.Windows.Forms.TextBox T_VatValue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox T_Vatpercent;
        public System.Windows.Forms.TextBox T_Sale_Total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox T_Discount;
        public System.Windows.Forms.TextBox T_AllTotal;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox T_QuantityRES;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button btn_New;
        public System.Windows.Forms.Button btn_SAVE;
        public System.Windows.Forms.Button btn_EXIT;
        public System.Windows.Forms.Button btn_ERASE;
        public System.Windows.Forms.Button PrintINVC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox T_Paid;
        public System.Windows.Forms.TextBox T_Res;
        public System.Windows.Forms.TextBox T_ArabicWords;
        public System.Windows.Forms.DataGridView dgList;
        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.TextBox T_total1;
        public System.Windows.Forms.Button btn_DELET;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox T_idCAT;
        public System.Windows.Forms.TextBox T_purchasing;
        public System.Windows.Forms.TextBox T_purchasingTOT;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}