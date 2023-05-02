namespace MobileShop2023.Login
{
    partial class frm_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Users));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_CLOSE = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_NEW = new System.Windows.Forms.Button();
            this.btn_UPDATE = new System.Windows.Forms.Button();
            this.btn_DELET = new System.Windows.Forms.Button();
            this.btn_SAVE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_User_ID = new System.Windows.Forms.TextBox();
            this.txt_User_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lab_PASS2 = new System.Windows.Forms.Label();
            this.txt_Password2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Username_login = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(394, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 257);
            this.listBox1.TabIndex = 114;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_CLOSE
            // 
            this.btn_CLOSE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CLOSE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CLOSE.ForeColor = System.Drawing.Color.Red;
            this.btn_CLOSE.Location = new System.Drawing.Point(274, 424);
            this.btn_CLOSE.Name = "btn_CLOSE";
            this.btn_CLOSE.Size = new System.Drawing.Size(115, 33);
            this.btn_CLOSE.TabIndex = 121;
            this.btn_CLOSE.Text = "خـــروج";
            this.btn_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CLOSE.UseVisualStyleBackColor = false;
            this.btn_CLOSE.Click += new System.EventHandler(this.btn_CLOSE_Click);
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(394, 159);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(193, 29);
            this.txt_search.TabIndex = 113;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Location = new System.Drawing.Point(274, 392);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 33);
            this.btn_cancel.TabIndex = 120;
            this.btn_cancel.Text = "إلغاء الأمر";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_NEW
            // 
            this.btn_NEW.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NEW.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NEW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_NEW.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NEW.Location = new System.Drawing.Point(6, 392);
            this.btn_NEW.Name = "btn_NEW";
            this.btn_NEW.Size = new System.Drawing.Size(129, 33);
            this.btn_NEW.TabIndex = 116;
            this.btn_NEW.Text = "سجل جديد";
            this.btn_NEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NEW.UseVisualStyleBackColor = false;
            this.btn_NEW.Click += new System.EventHandler(this.btn_NEW_Click);
            // 
            // btn_UPDATE
            // 
            this.btn_UPDATE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UPDATE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UPDATE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UPDATE.Location = new System.Drawing.Point(6, 424);
            this.btn_UPDATE.Name = "btn_UPDATE";
            this.btn_UPDATE.Size = new System.Drawing.Size(129, 33);
            this.btn_UPDATE.TabIndex = 118;
            this.btn_UPDATE.Text = "تعـديـل";
            this.btn_UPDATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_UPDATE.UseVisualStyleBackColor = false;
            this.btn_UPDATE.Click += new System.EventHandler(this.btn_UPDATE_Click);
            // 
            // btn_DELET
            // 
            this.btn_DELET.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DELET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DELET.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DELET.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DELET.Location = new System.Drawing.Point(129, 424);
            this.btn_DELET.Name = "btn_DELET";
            this.btn_DELET.Size = new System.Drawing.Size(147, 33);
            this.btn_DELET.TabIndex = 119;
            this.btn_DELET.Text = "حـــذف";
            this.btn_DELET.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DELET.UseVisualStyleBackColor = false;
            this.btn_DELET.Click += new System.EventHandler(this.btn_DELET_Click);
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SAVE.Enabled = false;
            this.btn_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SAVE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SAVE.Location = new System.Drawing.Point(129, 392);
            this.btn_SAVE.Name = "btn_SAVE";
            this.btn_SAVE.Size = new System.Drawing.Size(147, 33);
            this.btn_SAVE.TabIndex = 117;
            this.btn_SAVE.Text = "حـفـظ";
            this.btn_SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SAVE.UseVisualStyleBackColor = false;
            this.btn_SAVE.Click += new System.EventHandler(this.btn_SAVE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(263, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسـم الـمسـتـخدم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(263, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "الاسـم عند الدخـول";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(263, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقــم الـمسـتـخدم";
            // 
            // txt_User_ID
            // 
            this.txt_User_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_User_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User_ID.Location = new System.Drawing.Point(28, 34);
            this.txt_User_ID.Name = "txt_User_ID";
            this.txt_User_ID.ReadOnly = true;
            this.txt_User_ID.Size = new System.Drawing.Size(229, 27);
            this.txt_User_ID.TabIndex = 0;
            this.txt_User_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_User_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_User_ID_KeyDown);
            // 
            // txt_User_Name
            // 
            this.txt_User_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_User_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User_Name.Location = new System.Drawing.Point(28, 65);
            this.txt_User_Name.Name = "txt_User_Name";
            this.txt_User_Name.Size = new System.Drawing.Size(229, 27);
            this.txt_User_Name.TabIndex = 1;
            this.txt_User_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_User_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_User_ID_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(-11, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(-11, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(125, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(28, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 14);
            this.label13.TabIndex = 21;
            this.label13.Text = "حـقول إجباريـة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(263, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "كـلمـة الـمـرور";
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(28, 127);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(229, 27);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_User_ID_KeyDown);
            // 
            // lab_PASS2
            // 
            this.lab_PASS2.AutoSize = true;
            this.lab_PASS2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PASS2.ForeColor = System.Drawing.Color.Blue;
            this.lab_PASS2.Location = new System.Drawing.Point(263, 162);
            this.lab_PASS2.Name = "lab_PASS2";
            this.lab_PASS2.Size = new System.Drawing.Size(110, 19);
            this.lab_PASS2.TabIndex = 24;
            this.lab_PASS2.Text = " تـأكيد كلمـة المـرور";
            this.lab_PASS2.Visible = false;
            // 
            // txt_Password2
            // 
            this.txt_Password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password2.Location = new System.Drawing.Point(28, 157);
            this.txt_Password2.Name = "txt_Password2";
            this.txt_Password2.Size = new System.Drawing.Size(229, 27);
            this.txt_Password2.TabIndex = 4;
            this.txt_Password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password2.UseSystemPasswordChar = true;
            this.txt_Password2.Visible = false;
            this.txt_Password2.TextChanged += new System.EventHandler(this.txt_Password2_TextChanged);
            this.txt_Password2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_User_ID_KeyDown);
            this.txt_Password2.Validated += new System.EventHandler(this.txt_Password2_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(-11, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "*";
            this.label5.Visible = false;
            // 
            // txt_Username_login
            // 
            this.txt_Username_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username_login.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username_login.Location = new System.Drawing.Point(28, 96);
            this.txt_Username_login.Name = "txt_Username_login";
            this.txt_Username_login.Size = new System.Drawing.Size(229, 27);
            this.txt_Username_login.TabIndex = 2;
            this.txt_Username_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Username_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_User_ID_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(-11, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_Username_login);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Password2);
            this.panel1.Controls.Add(this.lab_PASS2);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_User_Name);
            this.panel1.Controls.Add(this.txt_User_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 215);
            this.panel1.TabIndex = 115;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(6, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(6, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 19);
            this.label12.TabIndex = 31;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(6, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 712;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(426, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 711;
            this.pictureBox2.TabStop = false;
            // 
            // frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(593, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_CLOSE);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_NEW);
            this.Controls.Add(this.btn_UPDATE);
            this.Controls.Add(this.btn_DELET);
            this.Controls.Add(this.btn_SAVE);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_Users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مستخدمي النظام";
            this.Load += new System.EventHandler(this.frm_Users_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Users_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button btn_CLOSE;
        public System.Windows.Forms.TextBox txt_search;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_NEW;
        public System.Windows.Forms.Button btn_UPDATE;
        public System.Windows.Forms.Button btn_DELET;
        public System.Windows.Forms.Button btn_SAVE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_User_ID;
        public System.Windows.Forms.TextBox txt_User_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lab_PASS2;
        public System.Windows.Forms.TextBox txt_Password2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Username_login;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}