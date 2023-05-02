using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShop2023.PL
{
    public partial class Form_BACKUP : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        SqlCommand cmd;
        public Form_BACKUP()
        {
            InitializeComponent();
        }

        private void Form_BACKUP_Load(object sender, EventArgs e)
        {
            BCreate.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; //  منع الفورم من التكبير بالفارة
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bbrowse_Click(object sender, EventArgs e)
        {
            BCreate.Enabled = true; ;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                T_TrackBackup.Text = folderBrowserDialog1.SelectedPath;
            BCreate.Enabled = true; 
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
            try
            {

                // طبعاً الفواصل الأخيرة لتغيير اسم المجلد لأن أي مجلد لا يقبل أي نقاط أو فواصل
                string track = T_TrackBackup.Text + "\\ MyData" + DateTime.Now.ToShortDateString().Replace('/', '-')
                    + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string strquery = "Backup Database MobileShop to Disk ='" + track + ". bak '";
                cmd = new SqlCommand(strquery, sqlcon);
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("تم إنشاء النسخة الإحتياطية بنجاح", "إنشاء النسخة الإحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception )
            {
                MessageBox.Show("(C)  مسار خاطئ - لا يمكن إنشاء نسخة على سطح المكتب أو على القرص المحلي ");
            }
           
            sqlcon.Close();
        }
    }
}
