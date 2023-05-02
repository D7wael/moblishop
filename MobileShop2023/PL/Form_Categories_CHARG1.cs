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
    public partial class Form_Categories_CHARG1 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        DataTable dt = new DataTable();
        BL.ALLPrograms log = new BL.ALLPrograms();

        SqlDataAdapter Da; // من أجل الصلاحيات
        DataTable Dt = new DataTable();
        public Form_Categories_CHARG1()
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

                //if (Dt.Rows[0][0].ToString() == "False" || Dt.Rows[0][0].ToString() == string.Empty)
                //    btn_SAVE.Enabled = false;

                if (Dt.Rows[0][1].ToString() == "False" || Dt.Rows[0][1].ToString() == string.Empty)
                    btn_UPDATE.Enabled = false;

                //if (Dt.Rows[0][2].ToString() == "False" || Dt.Rows[0][2].ToString() == string.Empty)
                //    btn_DELET.Enabled = false;

            }
            catch (Exception)
            {
            }
        }

        private void Form_Categories_CHARG1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void T_QuantityCharg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_QuantityCharg.Text.Length == 0)
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
            if (e.KeyChar == '.' && T_QuantityCharg.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void T_QuantityCharg_TextChanged(object sender, EventArgs e)
        {
            //DTM_Purchasing.Text = DTM_Purch1.Text.ToString();

            double QuantityCrrent, Quantity_Charg, Quantity_New;

            if (string.IsNullOrEmpty(TQN_Current.Text))
                QuantityCrrent = 0; // الكمية الحالية
            else
                QuantityCrrent = double.Parse(TQN_Current.Text);


            if (string.IsNullOrEmpty(T_QuantityCharg.Text))
                Quantity_Charg = 0;  // كمية الشحن
            else
                Quantity_Charg = double.Parse(T_QuantityCharg.Text);


            if (string.IsNullOrEmpty(T_Quantity_New.Text))
                Quantity_New = 0;  // الكمية الحديثة
            else
                Quantity_New = double.Parse(T_Quantity_New.Text);

            Quantity_New = QuantityCrrent + Quantity_Charg;
            T_Quantity_New.Text = Quantity_New.ToString();

            if (T_QuantityCharg.Text == "")
            {
                T_Quantity_New.Text = "";
            }
        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(T_Code_Catg.Text) && !string.IsNullOrEmpty(TQN_Current.Text) && !string.IsNullOrEmpty(T_Quantity_New.Text) && !string.IsNullOrEmpty(TQN_Current.Text))
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

                SqlCommand sqlcmd = new SqlCommand("update TB_Categories SET Quantity ='" + T_Quantity_New.Text +

               "'WHERE ID_CATG ='" + T_id.Text.ToString() + "'", sqlcon);
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
          
                MessageBox.Show("تم تحديث المخزون", "", MessageBoxButtons.OK);
            
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlcon.Close();

            T_Code_Catg.Text = null;
            T_CatgName.Text = null;
            T_Sale_Price.Text = null;
            T_QuantityCharg.Text = null;
            T_Quantity_New.Text = null;
            T_purchasing.Text = null;
            TQN_Current.Text = null;
            T_Minimum.Text = null;

            this.ActiveControl = T_Code_Catg;
            DTM_Purchasing.Value = DateTime.Now;
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Categories_CHARG1_Load(object sender, EventArgs e)
        {
            DTM_Purchasing.Text = DTM_Purch1.Text.ToString();// لجلب نفس التاريخ
            this.ActiveControl = T_QuantityCharg;
        }       
    }
}
