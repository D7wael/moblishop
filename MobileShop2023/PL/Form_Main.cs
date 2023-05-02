using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MobileShop2023.PL
{
    public partial class Form_Main : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        DataTable dt = new DataTable();

        SqlDataAdapter Da; // من أجل بصلاحيات الدخول 
        DataTable Dt = new DataTable();
        public Form_Main()
        {
            InitializeComponent();
                try
            {
                Da = new SqlDataAdapter("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + "", sqlcon);
                Da.Fill(Dt);
                if (Dt.Rows[0][0].ToString() == "False" || Dt.Rows[0][0].ToString() == string.Empty)
                    إضافةمستخدمToolStripMenuItem.Enabled = false;

                if (Dt.Rows[1][0].ToString() == "False" || Dt.Rows[1][0].ToString() == string.Empty)
                    إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;

                if (Dt.Rows[2][0].ToString() == "False" || Dt.Rows[2][0].ToString() == string.Empty)
                    استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;

                if (Dt.Rows[3][0].ToString() == "False" || Dt.Rows[3][0].ToString() == string.Empty)
                    تبديلالمستخدمToolStripMenuItem1.Enabled = false; 

                if (Dt.Rows[4][0].ToString() == "False" || Dt.Rows[4][0].ToString() == string.Empty)
                    إضافةصنفToolStripMenuItem.Enabled = false;

                if (Dt.Rows[5][0].ToString() == "False" || Dt.Rows[5][0].ToString() == string.Empty)
                    عرضالأصنافToolStripMenuItem.Enabled = false;

                if (Dt.Rows[6][0].ToString() == "False" || Dt.Rows[6][0].ToString() == string.Empty)
                    تغذيةالأصنافToolStripMenuItem.Enabled = false;

                if (Dt.Rows[7][0].ToString() == "False" || Dt.Rows[7][0].ToString() == string.Empty)
                    أمربيعToolStripMenuItem.Enabled = false;

                if (Dt.Rows[8][0].ToString() == "False" || Dt.Rows[8][0].ToString() == string.Empty)
                    عرضالمبيعاتToolStripMenuItem.Enabled = false;

                if (Dt.Rows[9][0].ToString() == "False" || Dt.Rows[9][0].ToString() == string.Empty)
                    إضافةمصروفToolStripMenuItem.Enabled = false;

                if (Dt.Rows[10][0].ToString() == "False" || Dt.Rows[10][0].ToString() == string.Empty)
                    عرضالمصروفاتToolStripMenuItem.Enabled = false;

                if (Dt.Rows[11][0].ToString() == "False" || Dt.Rows[11][0].ToString() == string.Empty)
                    تقاريرالمشترياتToolStripMenuItem.Enabled = false;

                if (Dt.Rows[12][0].ToString() == "False" || Dt.Rows[12][0].ToString() == string.Empty)
                    تقاريرالمبيعاتToolStripMenuItem.Enabled = false;

                if (Dt.Rows[13][0].ToString() == "False" || Dt.Rows[13][0].ToString() == string.Empty)
                    تقاريرالأصنافToolStripMenuItem.Enabled = false;

                if (Dt.Rows[14][0].ToString() == "False" || Dt.Rows[14][0].ToString() == string.Empty)
                    تقاريرالإيراداتToolStripMenuItem.Enabled = false;

                if (Dt.Rows[15][0].ToString() == "False" || Dt.Rows[15][0].ToString() == string.Empty)
                    تقاريرالمصروفاتToolStripMenuItem.Enabled = false;

                if (Dt.Rows[16][0].ToString() == "False" || Dt.Rows[16][0].ToString() == string.Empty)
                    عنالبرنامجToolStripMenuItem1.Enabled = false;
            }
            catch (Exception)
                {
                }
        }    
        private void Form_Main_Load(object sender, EventArgs e)
        {
        }      
        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }               
        private void تبديلالمستخدمToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pictureBox1.Show();
            Login.Frm_login lgn = new Login.Frm_login();
            lgn.ShowDialog();
            this.Close();
        }
        private void Form_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }    
        private void إنشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Form_BACKUP BAK = new Form_BACKUP();
            BAK.ShowDialog();
        }
        private void استعادةنسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Form_BACKUP_Restor RES = new Form_BACKUP_Restor();
            RES.ShowDialog();
        }
        private void إضافةمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Form_Add_Users mus = new Form_Add_Users();
            mus.ShowDialog();
        }
        private void إضافةصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Form_Categories CATG = new Form_Categories();
            CATG.ShowDialog(); 
        }
        private void أمربيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Form_Sales SAL = new Form_Sales();
            SAL.Show(); //  لفتح أكثر من شاشة مبيعات 
        }
        private void عرضالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Form_Categories_Zero CATGR = new Form_Categories_Zero();
            CATGR.ShowDialog();
        }
        private void عرضالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Form_Sales_SHOW SALE = new Form_Sales_SHOW();
            SALE.ShowDialog();
        }
        private void تقاريرالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.REP_Categories GTRS = new REP_Categories();
            GTRS.ShowDialog();
        }
        private void تقاريرالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.REP_Categories1 GTRS1 = new REP_Categories1();
            GTRS1.ShowDialog();
        }
        private void تقاريرالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.REP_Sales SALS1 = new REP_Sales();
            SALS1.ShowDialog();
        }
        private void تغذيةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Form_Categories_CHARG CATHH = new Form_Categories_CHARG();
            CATHH.ShowDialog();
        }
        private void تقاريرالإيراداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Profits PRFT = new Profits();
            PRFT.ShowDialog();
        }
        private void إضافةمصروفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Form_Spents SPNT = new Form_Spents();
            SPNT.ShowDialog();
        }
        private void عرضالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.Form_Spents_SHOW SPNTSH = new Form_Spents_SHOW();
            SPNTSH.ShowDialog();
        }
        private void تقاريرالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            PL.REP_Spents SPNTREP = new REP_Spents();
            SPNTREP.ShowDialog();
        }
        private void عنالبرنامجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.About abt = new About();
            abt.ShowDialog();
        }
    }
}
