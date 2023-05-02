using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using WIATest;
using System.Globalization;

namespace MobileShop2023.PL
{
    public partial class Form_Spents : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        DataTable dt = new DataTable();
        BL.ALLPrograms log = new BL.ALLPrograms();

        SqlDataAdapter Da; // من أجل الصلاحيات
        DataTable Dt = new DataTable();

        public Form_Spents()
        {
            InitializeComponent();

            T_HijriDate.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));

            LoadPriv();// تحميل الصلاحيات 
        }
        void LoadPriv()
        {
            try
            {
                Da = new SqlDataAdapter("select Priv_Add , Priv_Edit , Priv_Delete , Priv_Display FROM TB_Priv where  Priv_Screen_ID =1 and Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + "", sqlcon);
                Da.Fill(Dt);

                if (Dt.Rows[0][0].ToString() == "False" || Dt.Rows[0][0].ToString() == string.Empty)
                    btn_SAVE.Enabled = false;

                //if (Dt.Rows[0][1].ToString() == "False" || Dt.Rows[0][1].ToString() == string.Empty)
                //    btn_UPDATE.Enabled = false;

                //if (Dt.Rows[0][2].ToString() == "False" || Dt.Rows[0][2].ToString() == string.Empty)
                //    btn_DELET.Enabled = false;

            }
            catch (Exception)
            {
            }
        }
        private void Form_Spents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void T_SpentPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_SpentPrice.Text.Length == 0) // السماح للفاصلة
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && T_SpentPrice.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void btn_ERASE_Click(object sender, EventArgs e)
        {
            DTM_Spent.Value = DateTime.Now;
            T_SpentKind.Text = null;
            T_SpentPrice.Text = null;
            T_Name.Text = null;      
            this.ActiveControl = T_SpentKind;
        }
        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(T_SpentKind.Text) && !string.IsNullOrEmpty(T_SpentPrice.Text) && !string.IsNullOrEmpty(T_Name.Text))
            {
                this.Validate();
            }
            else
            {
                MessageBox.Show("يجب إدخال جميع البيانات");
                return;
            }

            try
            {
                SqlCommand sqlcmd = new SqlCommand("INSERT INTO TB_SPENTS(SpentKind, SpentPrice, DTMSpent, THijriDate, Name) values (@SpentKind, @SpentPrice ,@DTMSpent, @THijriDate, @Name)", sqlcon);
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@SpentKind", SqlDbType.VarChar);
                param[0].Value = T_SpentKind.Text;

                param[1] = new SqlParameter("@SpentPrice", SqlDbType.Float);
                param[1].Value = T_SpentPrice.Text;

                param[2] = new SqlParameter("@DTMSpent", SqlDbType.VarChar, 20);
                param[2].Value = DateTime.Parse(this.DTM_Spent.Text).ToString("yyyy-MM-dd");

                param[3] = new SqlParameter("@THijriDate", SqlDbType.VarChar, 20);
                param[3].Value = T_HijriDate.Text;        

                param[4] = new SqlParameter("@Name", SqlDbType.VarChar);
                param[4].Value = T_Name.Text;

                sqlcon.Open();
                sqlcmd.Parameters.AddRange(param);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("تم حفظ المصروف", "", MessageBoxButtons.OK);
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlcon.Close();

            T_SpentKind.Text = null;
            T_SpentPrice.Text = null;
            T_Name.Text = null;
            this.ActiveControl = T_SpentKind;
            DTM_Spent.Value = DateTime.Now;
        }

        private void T_SpentKind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
