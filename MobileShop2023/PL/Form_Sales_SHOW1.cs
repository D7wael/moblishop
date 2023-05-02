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
using NumberToWord;
using System.Globalization;

namespace MobileShop2023.PL
{
    public partial class Form_Sales_SHOW1 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        CurrencyManager cm;
        BindingManagerBase bmb;

        SqlDataAdapter Da; // من أجل الصلاحيات
        DataTable Dt = new DataTable();

        BL.ALLPrograms log = new BL.ALLPrograms();
        public string currentUser = Login.Frm_login.UserInformation.CurrentLoggedInUser; // لعرض اسم المستخدم الحالي
                                                                                         // اضغط على الخيار الأول فيتم استدعاء مكتبة الأرقام بعد إضافة كلاس توورد وكلاس كرنسي انفو أيضاً 
        List<CurrencyInfo> currencies = new List<CurrencyInfo>(); // لتحويل الأرقام

        public Form_Sales_SHOW1()
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

                //if (Dt.Rows[0][1].ToString() == "False" || Dt.Rows[0][1].ToString() == string.Empty)
                //    btn_UPDATE.Enabled = false;

                if (Dt.Rows[0][2].ToString() == "False" || Dt.Rows[0][2].ToString() == string.Empty)
                    btn_DELET.Enabled = false;

            }
            catch (Exception)
            {
            }
        }

        private void Form_Sales_SHOW1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form_Sales_SHOW1_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select ID_INV as 'id', InvoiceNo as 'رقم الفاتورة', SalerName as 'اسم البائع', CustomerName as 'اسم العميل', Phone as 'رقم الجوال', PaymentMethod as 'طريقة الدفع', Code_Catg as 'رقم الصنف' , CatgName as 'اسم الصنف', QuantitySales as 'الكمية' , Sale_Price as 'السعر الإفرادي' ,Sale_Total as 'السعر الإجمالي' ,Discount as 'الخصم' , Vatpercent as 'نسبة الضريبة %' , VatValue as 'قيمة الضريبة' , DTM_Sale as 'تاريخ البيع م' , THijriDate as 'تاريخ البيع هـ' , ID_CATG as 'idCATGS' FROM TB_Sales WHERE InvoiceNo = '" + T_InvoiceNo.Text + "' ", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;

            T_id.DataBindings.Add("text", dt, "id");
            T_InvoiceNo.DataBindings.Add("text", dt, "رقم الفاتورة");

            T_QuantitySales.DataBindings.Add("text", dt, "الكمية");
            T_Code_Catg.DataBindings.Add("text", dt, "رقم الصنف");

            T_Discount.DataBindings.Add("text", dt, "الخصم");
            T_Vatpercent.DataBindings.Add("text", dt, "نسبة الضريبة %");

            DTM_Sale.DataBindings.Add("text", dt, "تاريخ البيع م");
            T_HijriDate.DataBindings.Add("text", dt, "تاريخ البيع هـ");

            T_idCATGS.DataBindings.Add("text", dt, "idCATGS");


            bmb = this.BindingContext[dt];
            cm = (CurrencyManager)this.BindingContext[dt];
            position.Text = (cm.Position + 1) + " من " + cm.Count;

            dgList.Sort(dgList.Columns["تاريخ البيع م"], ListSortDirection.Descending); // للعرض من من أحدث تاريخ   

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // منع تكبير الفورم

            this.dgList.Columns["id"].Visible = false;
            this.dgList.Columns["اسم البائع"].Visible = false;
            this.dgList.Columns["اسم العميل"].Visible = false;
            this.dgList.Columns["رقم الجوال"].Visible = false;
            this.dgList.Columns["طريقة الدفع"].Visible = false;
            this.dgList.Columns["idCATGS"].Visible = false;
        
            this.dgList.Columns["الخصم"].Visible = false;
            this.dgList.Columns["نسبة الضريبة %"].Visible = false;
            this.dgList.Columns["قيمة الضريبة"].Visible = false;

            foreach (DataGridViewColumn col in dgList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            }


            this.dgList.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["رقم الفاتورة"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["اسم البائع"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["اسم العميل"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["رقم الجوال"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["طريقة الدفع"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgList.Columns["رقم الصنف"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["اسم الصنف"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["الكمية"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["السعر الإفرادي"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["السعر الإجمالي"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["الخصم"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["نسبة الضريبة %"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["قيمة الضريبة"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["تاريخ البيع م"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["تاريخ البيع هـ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            T_Total.Text =
     (from DataGridViewRow row in dgList.Rows
      where row.Cells[11].FormattedValue.ToString() != string.Empty
      select Convert.ToDouble(row.Cells["السعر الإجمالي"].FormattedValue)).Sum().ToString();


            try
            {
                double Total , QuantitySales, QuantityRES, TotQuantity , VatValue;


                if (string.IsNullOrEmpty(T_Total.Text))
                    Total = 0; // الإجمالي
                else
                    Total = double.Parse(T_Total.Text);


                if (string.IsNullOrEmpty(T_QuantitySales.Text))
                    QuantitySales = 0; // كمية البيع
                else
                    QuantitySales = double.Parse(T_QuantitySales.Text);

                if (string.IsNullOrEmpty(T_QuantityRES.Text))
                    QuantityRES = 0; // الكمية المتبقية
                else
                    QuantityRES = double.Parse(T_QuantityRES.Text);

                if (string.IsNullOrEmpty(T_TotQuantity.Text))
                    TotQuantity = 0; // الكمية المتبقية الحديثة
                else
                    TotQuantity = double.Parse(T_TotQuantity.Text);
        

                TotQuantity = QuantityRES + QuantitySales;
                T_TotQuantity.Text = TotQuantity.ToString();

                VatValue = (Total * 15) / 100;
                T_VatValue.Text = VatValue.ToString();

                Total = VatValue + Total;
                T_Total.Text = Total.ToString();


                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));// قراءة الأرقام
                ToWord toWord = new ToWord(Convert.ToDecimal(T_Total.Text), currencies[0]);
                T_ArabicWords.Text = toWord.ConvertToArabic();
                if (T_Total.Text == "1") // من عندي
                {
                    T_ArabicWords.Text = "واحد";
                }
                if (T_Total.Text.Split('.').Length > 1) // for coma reading
                {
                    T_ArabicWords.Text += " هللة";
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void bntFirst_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
            position.Text = (cm.Position + 1) + " من " + cm.Count;
        }

        private void btnPr_Click(object sender, EventArgs e)
        {
            cm.Position -= 1;
            position.Text = (cm.Position + 1) + " من " + cm.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cm.Position += 1;
            position.Text = (cm.Position + 1) + " من " + cm.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            cm.Position = cm.Count;
            position.Text = (cm.Position + 1) + " من " + cm.Count;
        }

        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //position.Text = (cm.Position + 1) + " من " + cm.Count;

            try
            {
            SqlCommand cmd = new SqlCommand("SELECT ID_CATG , Quantity FROM TB_Categories WHERE ID_CATG ='" + T_idCATGS.Text + "' ", sqlcon);
            cmd.Parameters.Add(new SqlParameter("@ID_CATG", T_idCATGS.Text));
            sqlcon.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                T_idCATGS.Text = Convert.ToString(reader.GetValue(0));
                T_QuantityRES.Text = Convert.ToString(reader.GetValue(1));
            }
            reader.Close();
            sqlcon.Close();
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlcon.Close();

            try
            {
                double QuantitySales, QuantityRES, TotQuantity;

                if (string.IsNullOrEmpty(T_QuantitySales.Text))
                    QuantitySales = 0; // كمية البيع
                else
                    QuantitySales = double.Parse(T_QuantitySales.Text);

                if (string.IsNullOrEmpty(T_QuantityRES.Text))
                    QuantityRES = 0; // الكمية المتبقية
                else
                    QuantityRES = double.Parse(T_QuantityRES.Text);

                if (string.IsNullOrEmpty(T_TotQuantity.Text))
                    TotQuantity = 0; // الكمية المتبقية الحديثة
                else
                    TotQuantity = double.Parse(T_TotQuantity.Text);


                TotQuantity = QuantityRES + QuantitySales;
                T_TotQuantity.Text = TotQuantity.ToString();

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

        }

        private void dgList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //position.Text = (cm.Position + 1) + " من " + cm.Count;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ID_CATG , Quantity FROM TB_Categories WHERE ID_CATG ='" + T_idCATGS.Text + "' ", sqlcon);
                cmd.Parameters.Add(new SqlParameter("@ID_CATG", T_idCATGS.Text));
                sqlcon.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    T_idCATGS.Text = Convert.ToString(reader.GetValue(0));
                    T_QuantityRES.Text = Convert.ToString(reader.GetValue(1));
                }
                reader.Close();
                sqlcon.Close();
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlcon.Close();
            try
            {
                double QuantitySales, QuantityRES, TotQuantity;


                if (string.IsNullOrEmpty(T_QuantitySales.Text))
                    QuantitySales = 0; // كمية البيع
                else
                    QuantitySales = double.Parse(T_QuantitySales.Text);

                if (string.IsNullOrEmpty(T_QuantityRES.Text))
                    QuantityRES = 0; // الكمية المتبقية
                else
                    QuantityRES = double.Parse(T_QuantityRES.Text);

                if (string.IsNullOrEmpty(T_TotQuantity.Text))
                    TotQuantity = 0; // الكمية المتبقية الحديثة
                else
                    TotQuantity = double.Parse(T_TotQuantity.Text);


                TotQuantity = QuantityRES + QuantitySales;
                T_TotQuantity.Text = TotQuantity.ToString();

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

        private void btn_DELET_Click(object sender, EventArgs e)
        {
            if (dgList.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد مبيعات مدخلة", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                if (MessageBox.Show("هل تريد حذف الفاتورة المحددة ؟", "الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM TB_Sales WHERE ID_INV = " + T_id.Text + "", sqlcon);
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();

                    button1.Enabled = true;// تمكين التحديث

                    sqlcon.Close();

                    button1.PerformClick();

                    MessageBox.Show("تم الحذف بنجاج  ", " الحذف ");
                    cm.RemoveAt(cm.Position);
                    da.Update(dt);

                }
                else
                    button1.Enabled = false; // منع التحديث
                MessageBox.Show("تم إلغاء الحذف");
            }
            catch (System.Exception)
            {
                //MessageBox.Show(excep.Message); // تم تعطيله ليتم تحديث الحذف مباشرة
            }
            sqlcon.Close();
            position.Text = (cm.Position + 1) + " من " + cm.Count;


            T_Total.Text =
     (from DataGridViewRow row in dgList.Rows
      where row.Cells[11].FormattedValue.ToString() != string.Empty
      select Convert.ToDouble(row.Cells["السعر الإجمالي"].FormattedValue)).Sum().ToString();

            try
            {
                double Total, QuantitySales, QuantityRES, TotQuantity , VatValue;

                if (string.IsNullOrEmpty(T_Total.Text))
                    Total = 0; // سعر البيع الإفرادي الإفرادي + الضريبة
                else
                    Total = double.Parse(T_Total.Text);


                if (string.IsNullOrEmpty(T_QuantitySales.Text))
                    QuantitySales = 0; // كمية البيع
                else
                    QuantitySales = double.Parse(T_QuantitySales.Text);

                if (string.IsNullOrEmpty(T_QuantityRES.Text))
                    QuantityRES = 0; // الكمية المتبقية
                else
                    QuantityRES = double.Parse(T_QuantityRES.Text);

                if (string.IsNullOrEmpty(T_TotQuantity.Text))
                    TotQuantity = 0; // الكمية المتبقية الحديثة
                else
                    TotQuantity = double.Parse(T_TotQuantity.Text);

                if (string.IsNullOrEmpty(T_VatValue.Text))
                    VatValue = 0; // قيمة الضريبة المضافة بعد الحذف
                else
                    VatValue = double.Parse(T_VatValue.Text);


                TotQuantity = QuantityRES + QuantitySales;
                T_TotQuantity.Text = TotQuantity.ToString();

                VatValue = (Total * 15)/100;
                T_VatValue.Text = VatValue.ToString();

                Total = VatValue + Total;
                T_Total.Text = Total.ToString();


                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));// قراءة الأرقام
                ToWord toWord = new ToWord(Convert.ToDecimal(T_Total.Text), currencies[0]);
                T_ArabicWords.Text = toWord.ConvertToArabic();
                if (T_Total.Text == "1") // من عندي
                {
                    T_ArabicWords.Text = "واحد";
                }
                if (T_Total.Text.Split('.').Length > 1) // for coma reading
                {
                    T_ArabicWords.Text += " هللة";
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

            try
            {
                SqlCommand sqlcmd = new SqlCommand("update TB_Sales SET VatValue ='" + T_VatValue.Text +

              "',AllTotal =   '" + T_Total.Text +
                "'WHERE ID_INV ='" + T_id.Text.ToString() + "'", sqlcon);
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                       
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlcon.Close();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("update TB_Sales SET ArabicWords ='" + T_ArabicWords.Text +

                "'WHERE InvoiceNo ='" + T_InvoiceNo.Text.ToString() + "'", sqlcon);
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();

                //"'WHERE Code_Catg ='" + T_Code_Catg.Text.ToString() + "'", sqlcon);

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlcon.Close();
        }
        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double QuantitySales, QuantityRES, TotQuantity;


                if (string.IsNullOrEmpty(T_QuantitySales.Text))
                    QuantitySales = 0; // كمية البيع
                else
                    QuantitySales = double.Parse(T_QuantitySales.Text);

                if (string.IsNullOrEmpty(T_QuantityRES.Text))
                    QuantityRES = 0; // الكمية المتبقية
                else
                    QuantityRES = double.Parse(T_QuantityRES.Text);

                if (string.IsNullOrEmpty(T_TotQuantity.Text))
                    TotQuantity = 0; // الكمية المتبقية الحديثة
                else
                    TotQuantity = double.Parse(T_TotQuantity.Text);


                TotQuantity = QuantityRES + QuantitySales;
                T_TotQuantity.Text = TotQuantity.ToString();

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in dgList.Rows)
                {
                    SqlCommand sqlcmd = new SqlCommand("update TB_Categories SET Quantity=@Quantity WHERE Code_Catg=@Code_Catg ", sqlcon);

                    sqlcmd.Parameters.AddWithValue("@Quantity", T_TotQuantity.Text);// تكتب الكمية المتبقية من بعد الحذف
                    sqlcmd.Parameters.AddWithValue("@Code_Catg", T_Code_Catg.Text);  //  

                    sqlcon.Open();
                    sqlcmd.ExecuteNonQuery();
                    sqlcon.Close();

                    ////MessageBox.Show("تم تحديث المخزون بنجاح", " ", MessageBoxButtons.OK);
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlcon.Close();
        }

        private void T_Reset_Click(object sender, EventArgs e)
        {

        }
    }
}
