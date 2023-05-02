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
    public partial class Form_BACKUP_Restor : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        SqlCommand cmd;
        public Form_BACKUP_Restor()
        {
            InitializeComponent();
        }

        private void Form_BACKUP_Restor_Load(object sender, EventArgs e)
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
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files (*.bak)|*.bak|All files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                T_TrackBackup.Text = dlg.FileName;

                BCreate.Enabled = true;
            }
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
            try
            {

                // مهم جداً من أجل تحقيق  الإستعادة حتى لوكان القاعدة مفتوحة -- يغلقها ثم يستعيدها 
                string strquery = " ALTER Database MobileShop SET OFFLINE WITH ROLLBACK IMMEDIATE ; Restore Database CarsTires From Disk ='" + T_TrackBackup.Text + "'";
                cmd = new SqlCommand(strquery, sqlcon);
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("تم استعادة النسخة الإحتياطية بنجاح", "استعادة النسخة الإحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("ملف خاطئ - الرجاء المحاولة مرة أخرى");
            }
        }
    }
}
