namespace MobileShop2023.Login
{
    partial class Frm_Priv_user
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Priv_user));
            this.btn_exit = new System.Windows.Forms.Button();
            this.butn_Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list_showlist = new System.Windows.Forms.ListBox();
            this.list_user = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labels = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.butn_UnSelect = new System.Windows.Forms.Button();
            this.butn_SelectAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(747, 398);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(135, 34);
            this.btn_exit.TabIndex = 131;
            this.btn_exit.Text = "خــروج";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // butn_Save
            // 
            this.butn_Save.BackColor = System.Drawing.SystemColors.Window;
            this.butn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butn_Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.butn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butn_Save.Location = new System.Drawing.Point(467, 398);
            this.butn_Save.Name = "butn_Save";
            this.butn_Save.Size = new System.Drawing.Size(135, 34);
            this.butn_Save.TabIndex = 130;
            this.butn_Save.Text = "حـفـظ الـصلاحـيات";
            this.butn_Save.UseVisualStyleBackColor = false;
            this.butn_Save.Click += new System.EventHandler(this.butn_Save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(183, 74);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 308);
            this.dataGridView1.TabIndex = 129;
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_search.Location = new System.Drawing.Point(1030, 51);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(155, 25);
            this.txt_search.TabIndex = 128;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 45);
            this.label2.TabIndex = 127;
            this.label2.Text = "الـــقـائمة الأسـاسـيـة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_showlist
            // 
            this.list_showlist.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_showlist.ForeColor = System.Drawing.Color.Blue;
            this.list_showlist.FormattingEnabled = true;
            this.list_showlist.ItemHeight = 23;
            this.list_showlist.Location = new System.Drawing.Point(25, 74);
            this.list_showlist.Name = "list_showlist";
            this.list_showlist.Size = new System.Drawing.Size(155, 303);
            this.list_showlist.TabIndex = 126;
            this.list_showlist.SelectedIndexChanged += new System.EventHandler(this.list_showlist_SelectedIndexChanged);
            // 
            // list_user
            // 
            this.list_user.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_user.ForeColor = System.Drawing.Color.Red;
            this.list_user.FormattingEnabled = true;
            this.list_user.ItemHeight = 23;
            this.list_user.Location = new System.Drawing.Point(1030, 74);
            this.list_user.Name = "list_user";
            this.list_user.Size = new System.Drawing.Size(155, 303);
            this.list_user.TabIndex = 125;
            this.list_user.SelectedIndexChanged += new System.EventHandler(this.list_user_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1030, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 124;
            this.label1.Text = "بحـث ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.BackColor = System.Drawing.SystemColors.Control;
            this.labels.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labels.ForeColor = System.Drawing.Color.MediumBlue;
            this.labels.Location = new System.Drawing.Point(46, 20);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(565, 19);
            this.labels.TabIndex = 109;
            this.labels.Text = "لتمكين الصلاحية أضف علامة صح في المربع المخصص , ولإلغاء الصلاحية أزل علامة الصح م" +
    "ن المربع";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // butn_UnSelect
            // 
            this.butn_UnSelect.BackColor = System.Drawing.SystemColors.Window;
            this.butn_UnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butn_UnSelect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn_UnSelect.ForeColor = System.Drawing.Color.Maroon;
            this.butn_UnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butn_UnSelect.Location = new System.Drawing.Point(607, 398);
            this.butn_UnSelect.Name = "butn_UnSelect";
            this.butn_UnSelect.Size = new System.Drawing.Size(135, 34);
            this.butn_UnSelect.TabIndex = 134;
            this.butn_UnSelect.Text = "إلغاء التحديد";
            this.butn_UnSelect.UseVisualStyleBackColor = false;
            this.butn_UnSelect.Click += new System.EventHandler(this.butn_UnSelect_Click);
            // 
            // butn_SelectAll
            // 
            this.butn_SelectAll.BackColor = System.Drawing.SystemColors.Window;
            this.butn_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butn_SelectAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn_SelectAll.ForeColor = System.Drawing.Color.Blue;
            this.butn_SelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butn_SelectAll.Location = new System.Drawing.Point(328, 398);
            this.butn_SelectAll.Name = "butn_SelectAll";
            this.butn_SelectAll.Size = new System.Drawing.Size(135, 34);
            this.butn_SelectAll.TabIndex = 133;
            this.butn_SelectAll.Text = "تحديد الكل";
            this.butn_SelectAll.UseVisualStyleBackColor = false;
            this.butn_SelectAll.Click += new System.EventHandler(this.butn_SelectAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labels);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(285, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(642, 45);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1174, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1108;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Priv_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1174, 458);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.butn_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_showlist);
            this.Controls.Add(this.list_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butn_UnSelect);
            this.Controls.Add(this.butn_SelectAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_Priv_user";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تمكين الصلاحيات / إلغاء الصلاحيات";
            this.Load += new System.EventHandler(this.Frm_Priv_user_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Priv_user_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button butn_Save;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txt_search;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox list_showlist;
        public System.Windows.Forms.ListBox list_user;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labels;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button butn_UnSelect;
        public System.Windows.Forms.Button butn_SelectAll;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}