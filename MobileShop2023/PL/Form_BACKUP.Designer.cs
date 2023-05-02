namespace MobileShop2023.PL
{
    partial class Form_BACKUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BACKUP));
            this.Bbrowse = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.BCreate = new System.Windows.Forms.Button();
            this.T_TrackBackup = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bbrowse
            // 
            this.Bbrowse.BackColor = System.Drawing.Color.Transparent;
            this.Bbrowse.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbrowse.ForeColor = System.Drawing.Color.Blue;
            this.Bbrowse.Location = new System.Drawing.Point(39, 29);
            this.Bbrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bbrowse.Name = "Bbrowse";
            this.Bbrowse.Size = new System.Drawing.Size(220, 34);
            this.Bbrowse.TabIndex = 199;
            this.Bbrowse.Text = "حدد مسار حفظ النسخة";
            this.Bbrowse.UseVisualStyleBackColor = false;
            this.Bbrowse.Click += new System.EventHandler(this.Bbrowse_Click);
            // 
            // BCancel
            // 
            this.BCancel.BackColor = System.Drawing.Color.Transparent;
            this.BCancel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancel.ForeColor = System.Drawing.Color.Red;
            this.BCancel.Location = new System.Drawing.Point(345, 119);
            this.BCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(138, 34);
            this.BCancel.TabIndex = 202;
            this.BCancel.Text = "خروج";
            this.BCancel.UseVisualStyleBackColor = false;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BCreate
            // 
            this.BCreate.BackColor = System.Drawing.Color.Transparent;
            this.BCreate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BCreate.Location = new System.Drawing.Point(211, 119);
            this.BCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BCreate.Name = "BCreate";
            this.BCreate.Size = new System.Drawing.Size(138, 34);
            this.BCreate.TabIndex = 201;
            this.BCreate.Text = "إنشاء النسخة";
            this.BCreate.UseVisualStyleBackColor = false;
            this.BCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // T_TrackBackup
            // 
            this.T_TrackBackup.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_TrackBackup.Location = new System.Drawing.Point(39, 63);
            this.T_TrackBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_TrackBackup.Name = "T_TrackBackup";
            this.T_TrackBackup.ReadOnly = true;
            this.T_TrackBackup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.T_TrackBackup.Size = new System.Drawing.Size(477, 35);
            this.T_TrackBackup.TabIndex = 200;
            this.T_TrackBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 203;
            this.pictureBox1.TabStop = false;
            // 
            // Form_BACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(698, 266);
            this.Controls.Add(this.Bbrowse);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BCreate);
            this.Controls.Add(this.T_TrackBackup);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_BACKUP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إنشاء نسخة احتياطية";
            this.Load += new System.EventHandler(this.Form_BACKUP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Bbrowse;
        public System.Windows.Forms.Button BCancel;
        public System.Windows.Forms.Button BCreate;
        public System.Windows.Forms.TextBox T_TrackBackup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}