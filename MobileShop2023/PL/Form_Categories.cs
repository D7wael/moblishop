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
    public partial class Form_Categories : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        DataTable dt = new DataTable();
        BL.ALLPrograms log = new BL.ALLPrograms();

        SqlDataAdapter Da; // من أجل الصلاحيات
        DataTable Dt = new DataTable();

        public Form_Categories()
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

        private void Form_Categories_KeyDown(object sender, KeyEventArgs e)
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

        private void T_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_Quantity.Text.Length == 0)
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
            if (e.KeyChar == '.' && T_Quantity.Text.IndexOf('.') > -1)
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

        private void btn_ERASE_Click(object sender, EventArgs e)
        {
            DTM_Purchasing.Value = DateTime.Now;

            T_Code_Catg.Text = null;
            T_CatgName.Text = null;
         
            T_Quantity.Text = null;
            T_Minimum.Text = null;
            T_purchasing.Text = null;
            T_Sale_Price.Text = null;

            PBox.Image=null;

            this.ActiveControl = T_Code_Catg;

            //comb_Status.SelectedIndex = -1;
        }

        private void T_Sale_Price_TextChanged(object sender, EventArgs e)
        {
        }

        private void T_purchasing_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Quantity , purchasing , purchasingTOT;

                if (string.IsNullOrEmpty(T_Quantity.Text))
                    Quantity = 0; // الكمية
                else
                    Quantity = double.Parse(T_Quantity.Text);

                if (string.IsNullOrEmpty(T_purchasing.Text))
                    purchasing = 0; // شعر الشراء الإفرادي
                else
                    purchasing = double.Parse(T_purchasing.Text);

                if (string.IsNullOrEmpty(T_TOTpurchasing.Text))
                    purchasingTOT = 0; // شعر الشراء الإجمالي
                else
                    purchasingTOT = double.Parse(T_TOTpurchasing.Text);
           
                purchasingTOT = Quantity * purchasing;
                T_TOTpurchasing.Text = purchasingTOT.ToString();


                if (T_purchasing.Text == "")
                {
                    T_TOTpurchasing.Text = "";
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(T_Code_Catg.Text) && !string.IsNullOrEmpty(T_CatgName.Text) && !string.IsNullOrEmpty(T_Quantity.Text) && !string.IsNullOrEmpty(T_Minimum.Text) && !string.IsNullOrEmpty(T_purchasing.Text)&& !string.IsNullOrEmpty(T_Sale_Price.Text))
            {
                this.Validate();
            }
            else
            {
                MessageBox.Show("يجب إدخال جميع البيانات");
                return;
            }

            if (PBox.Image != null)
            {
                this.Validate();
            }
            else
            {
                MessageBox.Show("يجب إدراج صورة الصنف");
                return;
            }

            try
            {

                SqlCommand sqlcmd = new SqlCommand("INSERT INTO TB_Categories(Code_Catg,CatgName, Quantity,TMinimum,purchasing , DTM_Purchasing, THijriDate, Sale_Price ,TOTpurchasing,MG) values (@Code_Catg,@CatgName, @Quantity,@TMinimum,@purchasing , @DTM_Purchasing, @THijriDate, @Sale_Price, @TOTpurchasing,@MG)", sqlcon);
                SqlParameter[] param = new SqlParameter[10];

                MemoryStream ms = new MemoryStream();
                PBox.Image.Save(ms, PBox.Image.RawFormat);
                byte[] img = ms.ToArray();

                param[0] = new SqlParameter("@Code_Catg", SqlDbType.VarChar);
                param[0].Value = T_Code_Catg.Text;

                param[1] = new SqlParameter("@CatgName", SqlDbType.VarChar);
                param[1].Value = T_CatgName.Text;

                param[2] = new SqlParameter("@Quantity", SqlDbType.Float);
                param[2].Value = T_Quantity.Text;

                param[3] = new SqlParameter("@TMinimum", SqlDbType.Float);
                param[3].Value = T_Minimum.Text;

                param[4] = new SqlParameter("@purchasing", SqlDbType.Float);
                param[4].Value = T_purchasing.Text;             

                param[5] = new SqlParameter("@DTM_Purchasing", SqlDbType.VarChar, 20);
                param[5].Value = DateTime.Parse(this.DTM_Purchasing.Text).ToString("yyyy-MM-dd");

                param[6] = new SqlParameter("@THijriDate", SqlDbType.VarChar, 20);
                param[6].Value = T_HijriDate.Text;

                param[7] = new SqlParameter("@Sale_Price", SqlDbType.Float);
                param[7].Value = T_Sale_Price.Text;

                param[8] = new SqlParameter("@TOTpurchasing", SqlDbType.Float);
                param[8].Value = T_TOTpurchasing.Text;

                param[9] = new SqlParameter("@MG", SqlDbType.Image);
                param[9].Value = img;

                sqlcon.Open();
                sqlcmd.Parameters.AddRange(param);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();


                MessageBox.Show("تم حفظ الصنف", "", MessageBoxButtons.OK);
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlcon.Close();

            T_Code_Catg.Text = null;
            T_CatgName.Text = null;
           
            T_Quantity.Text = null;
            T_Minimum.Text = null;
            T_purchasing.Text = null;
            T_Sale_Price.Text = null;
            PBox.Image = null;

            this.ActiveControl = T_Code_Catg;
            DTM_Purchasing.Value = DateTime.Now;
        }

        private void T_Code_Catg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) 
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void T_Code_Catg_Validated(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = log.Prevent_CodeCatg(T_Code_Catg.Text);
            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("كود الصنف مكرر", "تكرار ", MessageBoxButtons.OK);
                T_Code_Catg.Text = null;
                this.ActiveControl = T_Code_Catg;
            }
        }

        private void Form_Categories_Load(object sender, EventArgs e)
        {
            this.ActiveControl = T_Code_Catg;
        }

        private void DTM_Purchasing_ValueChanged(object sender, EventArgs e)
        {
            T_HijriDate.Text = DTM_Purchasing.Value.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));
        }

        private void T_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (T_Quantity.Text == "")
            {
                T_purchasing.Text = "";
            }

            if (T_Quantity.Text == "")
            {
                T_TOTpurchasing.Text = "";
            }
        }

        private void btn_Scanar_Click(object sender, EventArgs e)
        {
            try
            {
                //get list of devices available
                List<string> devices = WIAScanner.GetDevices();

                foreach (string device in devices)
                {
                    lbDevices.Items.Add(device);
                }
                //check if device is not available
                if (lbDevices.Items.Count == 0)
                {
                    MessageBox.Show("لم يتم العثور على ماسح ضوئي");
                    return;
                    //this.Close(); // فيه مشكلة لانه يغلق الواجهة اذا لم يعثر على الماسح
                }
                else
                {
                    lbDevices.SelectedIndex = 0;
                }

                //get images from scanner
                List<Image> images = WIAScanner.Scan((string)lbDevices.SelectedItem);
                foreach (Image image in images)
                {
                    PBox.Image = image;
                    PBox.Show();
                    PBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    //save scanned image into specific folder
                    //image.Save(@"D:\" + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpeg", ImageFormat.Jpeg);
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
    }

        private void btn_Shose_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();

            // "نسق الصور
            opd.Filter = "Image File (*.jpg;*.bmp;*.gif ,*.PNG;)|*.jpg;*.bmp;*.gif,*.PNG;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                PBox.Image = Image.FromFile(opd.FileName);
            }
        }
    }
}
