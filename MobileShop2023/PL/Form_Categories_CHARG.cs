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
    public partial class Form_Categories_CHARG : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        DataTable dt = new DataTable();
        BL.ALLPrograms log = new BL.ALLPrograms();

        SqlDataAdapter Da; // من أجل الصلاحيات
        DataTable Dt = new DataTable();

        public Form_Categories_CHARG()
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

        private void Form_Categories_CHARG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void T_purchasing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_purchasing.Text.Length == 0) // السماح للفاصلة
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
            if (e.KeyChar == '.' && T_purchasing.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void T_Sale_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_Sale_Price.Text.Length == 0) // السماح للفاصلة
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
            if (e.KeyChar == '.' && T_Sale_Price.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void T_Minimum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_Minimum.Text.Length == 0)
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
            if (e.KeyChar == '.' && T_Minimum.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Categories_CHARG_Load(object sender, EventArgs e)
        {
            this.ActiveControl = T_Code_Catg;
        }

        private void DTM_Purchasing_ValueChanged(object sender, EventArgs e)
        {
            T_HijriDate.Text = DTM_Purchasing.Value.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));
        }

        private void T_Sale_Price_TextChanged(object sender, EventArgs e)
        {
        }

        private void T_Code_Catg_KeyDown(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Code_Catg, CatgName, Quantity, Sale_Price , ID_CATG, TMinimum, purchasing , DTM_Purchasing , THijriDate , Sale_Price FROM TB_Categories  WHERE Code_Catg = @Code_Catg", sqlcon);
            cmd.Parameters.Add(new SqlParameter("@Code_Catg", T_Code_Catg.Text));
            sqlcon.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                T_Code_Catg.Text = reader.GetString(0);
                T_CatgName.Text = reader.GetString(1);
                TQN_Current.Text = Convert.ToString(reader.GetValue(2));
                T_Sale_Price.Text = Convert.ToString(reader.GetValue(3));
                T_id.Text = Convert.ToString(reader.GetValue(4));

                T_Minimum.Text = Convert.ToString(reader.GetValue(5));
                T_purchasing.Text = Convert.ToString(reader.GetValue(6));
                DTM_Purchasing.Text = Convert.ToString(reader.GetValue(7));
                T_HijriDate.Text = Convert.ToString(reader.GetValue(8));
                T_Sale_Price.Text = Convert.ToString(reader.GetValue(9));

            }
            reader.Close();
            sqlcon.Close();
        }
       
        private void T_Quantity_Charg_KeyPress(object sender, KeyPressEventArgs e)
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

        private void T_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TQN_Current.Text.Length == 0)
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
            if (e.KeyChar == '.' && TQN_Current.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void T_QuantityCharg_TextChanged(object sender, EventArgs e)
        {
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
            if (!string.IsNullOrEmpty(T_Code_Catg.Text) && !string.IsNullOrEmpty(TQN_Current.Text) && !string.IsNullOrEmpty(T_Quantity_New.Text) && !string.IsNullOrEmpty(T_purchasing.Text) && !string.IsNullOrEmpty(T_Sale_Price.Text) && !string.IsNullOrEmpty(TQN_Current.Text))
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

                SqlCommand cmd = new SqlCommand("update TB_Categories SET Code_Catg ='" + T_Code_Catg.Text +

                 "', CatgName = '" + T_CatgName.Text +
                 "', Quantity = '" + T_Quantity_New.Text +
                 "', TMinimum = '" + T_Minimum.Text +
                 "', purchasing = '" + T_purchasing.Text +
                 "', DTM_Purchasing = '" + DTM_Purchasing.Text +
                 "', THijriDate = '" + T_HijriDate.Text +
                 "', Sale_Price = '" + T_Sale_Price.Text +

                 "'WHERE ID_CATG ='" + T_id.Text + "'", sqlcon);

                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("تم تحديث المخزون", "", MessageBoxButtons.OK);
                dt.Clear();
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

        private void T_Code_Catg_TextChanged(object sender, EventArgs e)
        {
            if (T_Code_Catg.Text == "")

            T_CatgName.Text = null;
            T_Sale_Price.Text = null;
            T_QuantityCharg.Text = null;
            T_Quantity_New.Text = null;
            T_purchasing.Text = null;
            TQN_Current.Text = null;
            T_Minimum.Text = null;

            DTM_Purchasing.Value = DateTime.Now;
            this.ActiveControl = T_Code_Catg;
        }

        private void btn_ERASE_Click(object sender, EventArgs e)
        {
            T_CatgName.Text = null;
            T_Sale_Price.Text = null;
            T_QuantityCharg.Text = null;
            T_Quantity_New.Text = null;
            T_purchasing.Text = null;
            TQN_Current.Text = null;
            T_Minimum.Text = null;

            DTM_Purchasing.Value = DateTime.Now;
            this.ActiveControl = T_Code_Catg;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
