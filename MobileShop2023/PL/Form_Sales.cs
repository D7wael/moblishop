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
using NumberToWord;

namespace MobileShop2023.PL
{
    public partial class Form_Sales : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        DataTable dt = new DataTable();     
        BL.ALLPrograms log = new BL.ALLPrograms();
        public string currentUser = Login.Frm_login.UserInformation.CurrentLoggedInUser; // لعرض اسم المستخدم الحالي

        List<CurrencyInfo> currencies = new List<CurrencyInfo>(); // لتحويل الأرقام

        SqlDataAdapter Da; // من أجل الصلاحيات
        DataTable Dt = new DataTable();
        public Form_Sales()
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

        private void Form_Sales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void T_Paid_TextChanged(object sender, EventArgs e)
        {
            if (T_Paid.Text == "")
                T_Res.Text = T_Paid.Text;

            try
            {

                T_Res.Text = (Double.Parse(T_Paid.Text) - Double.Parse(T_AllTotal.Text)).ToString();

            }
            catch (Exception)
            {
            }
        }

        private void btn_ERASE_Click(object sender, EventArgs e)
        {
            DTM_Sale.Value = DateTime.Now;

            T_InvoiceNo.Text = null;
            T_CustomerName.Text = null;
            T_Phone.Text = null;
            T_PaymentMethod.SelectedIndex = -1;

            T_Code_Catg.Text = null;
            T_CatgName.Text = null;
            T_QuantityCurrent.Text = null;
            T_QuantitySales.Text = null;
            T_Sale_Price.Text = null;
            T_Sale_Total.Text = null;
            T_Discount.Text = null;       
            T_Vatpercent.Text = null;
            T_VatValue.Text = null;
            T_AllTotal.Text = null;
            T_QuantityRES.Text = null;
            T_Paid.Text = null;
            T_Res.Text = null;

            T_total1.Text = null;
            dt.Clear();
            T_idCAT.Text = null;
            T_purchasing.Text = null;
            T_purchasingTOT.Text = null;
            PrintINVC.Enabled = false;
            this.ActiveControl = T_CustomerName;

        }

        private void btn_New_Click(object sender, EventArgs e)
        {



            DTM_Sale.Value = DateTime.Now;

            T_CustomerName.Text = null;
            T_Phone.Text = null;
            T_PaymentMethod.SelectedIndex = -1;

            T_Code_Catg.Text = null;
            T_CatgName.Text = null;
            T_QuantityCurrent.Text = null;
            T_QuantitySales.Text = null;
            T_Sale_Price.Text = null;
            T_Sale_Total.Text = null;
            T_Discount.Text = null;
            T_Vatpercent.Text = null;
            T_VatValue.Text = null;
            T_AllTotal.Text = null;
            T_QuantityRES.Text = null;
            T_Paid.Text = null;
            T_Res.Text = null;

            dt.Clear();
            T_idCAT.Text = null;
            T_purchasing.Text = null;
            T_purchasingTOT.Text = null;
            PrintINVC.Enabled = false;
            btn_SAVE.Enabled = true;
            DTM_Sale.Value = DateTime.Now;

            SqlCommand cmd = new SqlCommand("select ISNULL (MAX (InvoiceNo)+1,1) FROM TB_Sales", sqlcon);
            sqlcon.Open();
            SqlDataReader Ra = cmd.ExecuteReader();

            Ra.Read();
            T_InvoiceNo.Text = Ra[0].ToString();
            Ra.Close();
            sqlcon.Close();

            this.ActiveControl = T_CustomerName;

        }

        private void T_Vatpercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_Vatpercent.Text.Length == 0)
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
            if (e.KeyChar == '.' && T_Vatpercent.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void T_QuantitySales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_QuantitySales.Text.Length == 0)
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
            if (e.KeyChar == '.' && T_QuantitySales.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void T_Sale_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_Sale_Price.Text.Length == 0)
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

        private void T_Sale_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_Sale_Total.Text.Length == 0)
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
            if (e.KeyChar == '.' && T_Sale_Total.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void T_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_Discount.Text.Length == 0)
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
            if (e.KeyChar == '.' && T_Discount.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void T_Paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (T_Paid.Text.Length == 0)
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
            if (e.KeyChar == '.' && T_Paid.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void T_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void Form_Sales_Load(object sender, EventArgs e)
        {
            PrintINVC.Enabled = false;
            T_SalerName.Text = currentUser;  // لعرض اسم المستخدم الحالي
            this.ActiveControl = T_CustomerName;


            dt.Columns.Add("رقم الصنف", typeof(string));  // أفضل طريقة لإنشاء جدول كامل بدون استدعاء
            dt.Columns.Add("نوع الصنف", typeof(string));
            dt.Columns.Add("الكمية", typeof(double));
            dt.Columns.Add("السعر الإفرادي", typeof(double));
            dt.Columns.Add("السعر الإجمالي", typeof(double));

            //dt.Columns.Add("رقم الفاتورة", typeof(int));

            dt.Columns.Add("الكمية المتبقية", typeof(double));
            dt.Columns.Add("id_CATGS", typeof(int));

            dt.Columns.Add("سعر الشراء", typeof(double)); // يتسعمل في تقارير الإيرادات
            dt.Columns.Add("سعر الشراء الإجمالي", typeof(double)); // يتسعمل في تقارير الإيرادات


            //dt.Columns.Add("نسبة الضريبة", typeof(double));
            //dt.Columns.Add("قيمة الضريبة", typeof(double));
            //dt.Columns.Add("المجموع", typeof(double));



            dgList.DataSource = dt;


         


            try
            {

                ((DataTable)dgList.DataSource).Rows.Clear();  // هام جداً حتى يتم عرض البيانات المباعة الحالية فقط

                //this.dgList.Columns["رقم الصنف"].Visible = false;
           
            
                // توسيط جيمع عنواوين الجدول
                foreach (DataGridViewColumn col in dgList.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                this.dgList.Columns["رقم الصنف"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgList.Columns["نوع الصنف"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgList.Columns["الكمية"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgList.Columns["السعر الإفرادي"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgList.Columns["السعر الإجمالي"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //this.dgList.Columns["رقم الفاتورة"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.dgList.Columns["الكمية المتبقية"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgList.Columns["id_CATGS"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.dgList.Columns["سعر الشراء"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgList.Columns["سعر الشراء الإجمالي"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.dgList.Columns["الكمية المتبقية"].Visible = false;
                this.dgList.Columns["id_CATGS"].Visible = false;

                this.dgList.Columns["سعر الشراء"].Visible = false;
                this.dgList.Columns["سعر الشراء الإجمالي"].Visible = false;

            }
            catch (System.Exception)
            {
                //MessageBox.Show(excep.Message);
            }

        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(T_Discount.Text) && !string.IsNullOrEmpty(T_Vatpercent.Text) && !string.IsNullOrEmpty(T_AllTotal.Text) && !string.IsNullOrEmpty(T_InvoiceNo.Text) && !string.IsNullOrEmpty(T_PaymentMethod.Text))
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

                foreach (DataGridViewRow row in dgList.Rows)
                {
                    SqlCommand cmd = new SqlCommand("insert into TB_Sales (Code_Catg,CatgName, QuantitySales, Sale_Price, Sale_Total, InvoiceNo , Discount ,Vatpercent ,VatValue ,AllTotal ,DTM_Sale ,THijriDate, ArabicWords ,QuantityRES ,SalerName ,CustomerName, Phone ,PaymentMethod ,ID_CATG, purchasingTOT) values (@Code_Catg,@CatgName, @QuantitySales, @Sale_Price, @Sale_Total, @InvoiceNo ,@Discount ,@Vatpercent ,@VatValue ,@AllTotal ,@DTM_Sale ,@THijriDate, @ArabicWords ,@QuantityRES ,@SalerName ,@CustomerName, @Phone ,@PaymentMethod ,@ID_CATG, @purchasingTOT)", sqlcon);

                    cmd.Parameters.AddWithValue("@Code_Catg", row.Cells["رقم الصنف"].Value);
                    cmd.Parameters.AddWithValue("@CatgName", row.Cells["نوع الصنف"].Value);
                    cmd.Parameters.AddWithValue("@QuantitySales", row.Cells["الكمية"].Value);
                    cmd.Parameters.AddWithValue("@Sale_Price", row.Cells["السعر الإفرادي"].Value);
                    cmd.Parameters.AddWithValue("@Sale_Total", row.Cells["السعر الإجمالي"].Value);

                    cmd.Parameters.AddWithValue("@InvoiceNo", T_InvoiceNo.Text);

                    cmd.Parameters.AddWithValue("@QuantityRES", row.Cells["الكمية المتبقية"].Value);
                    cmd.Parameters.AddWithValue("@ID_CATG", row.Cells["id_CATGS"].Value);

                    cmd.Parameters.AddWithValue("@Discount", T_Discount.Text);
                    cmd.Parameters.AddWithValue("@Vatpercent", T_Vatpercent.Text);
                    cmd.Parameters.AddWithValue("@VatValue", T_VatValue.Text);
                    cmd.Parameters.AddWithValue("@AllTotal", T_AllTotal.Text);

                    cmd.Parameters.AddWithValue("@DTM_Sale", DTM_Sale.Text);
                    cmd.Parameters.AddWithValue("@THijriDate", T_HijriDate.Text);
                    cmd.Parameters.AddWithValue("@ArabicWords", T_ArabicWords.Text);

                    cmd.Parameters.AddWithValue("@SalerName", T_SalerName.Text);
                    cmd.Parameters.AddWithValue("@CustomerName", T_CustomerName.Text);
                    cmd.Parameters.AddWithValue("@Phone", T_Phone.Text);
                    cmd.Parameters.AddWithValue("@PaymentMethod", T_PaymentMethod.Text);

                    cmd.Parameters.AddWithValue("@purchasingTOT", row.Cells["سعر الشراء الإجمالي"].Value);


                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    //MessageBox.Show("تم حفظ الفاتورة بنجاح", "", MessageBoxButtons.OK);
                }
                MessageBox.Show("تم حفظ الفاتورة بنجاح", "", MessageBoxButtons.OK);
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

            sqlcon.Close();
            PrintINVC.Enabled = true;

            try
            {
              
                foreach (DataGridViewRow row in dgList.Rows)
                {
                    SqlCommand sqlcmd = new SqlCommand("update TB_Categories SET Quantity=@Quantity WHERE ID_CATG=@ID_CATG ", sqlcon);

                    sqlcmd.Parameters.AddWithValue("@Quantity", row.Cells["الكمية المتبقية"].Value);
                    sqlcmd.Parameters.AddWithValue("@ID_CATG", row.Cells["id_CATGS"].Value);

                    sqlcon.Open();
                    sqlcmd.ExecuteNonQuery();
                    sqlcon.Close();

                    //MessageBox.Show("تم تحديث المخزون بنجاح", " ", MessageBoxButtons.OK);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            sqlcon.Close();
            btn_SAVE.Enabled = false;
        }

        private void DTM_Sale_ValueChanged(object sender, EventArgs e)
        {
            T_HijriDate.Text = DTM_Sale.Value.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));
        }

        private void T_SalerName_KeyDown(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Code_Catg, CatgName, Quantity, Sale_Price , ID_CATG , purchasing FROM TB_Categories  WHERE Code_Catg = @Code_Catg", sqlcon);
            cmd.Parameters.Add(new SqlParameter("@Code_Catg", T_Code_Catg.Text));
            sqlcon.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                T_Code_Catg.Text = reader.GetString(0);
                T_CatgName.Text = reader.GetString(1);
                T_QuantityCurrent.Text = Convert.ToString(reader.GetValue(2));
                T_Sale_Price.Text = Convert.ToString(reader.GetValue(3));
                T_idCAT.Text = Convert.ToString(reader.GetValue(4));
                T_purchasing.Text = Convert.ToString(reader.GetValue(5));
            }
            reader.Close();
            sqlcon.Close();

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void T_QuantitySales_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double QuantitySales, Sale_Price, Sale_Total , QuantityCurrent, QuantityRES, purchasing , purchasingTOT;

                if (string.IsNullOrEmpty(T_QuantitySales.Text))
                    QuantitySales = 0; // كمية البيع
                else
                    QuantitySales = double.Parse(T_QuantitySales.Text);

                if (string.IsNullOrEmpty(T_Sale_Price.Text))
                    Sale_Price = 0; // السعر الإفرادي
                else
                    Sale_Price = double.Parse(T_Sale_Price.Text);

                if (string.IsNullOrEmpty(T_Sale_Total.Text))
                    Sale_Total = 0; // السعر الإجمالي
                else
                    Sale_Total = double.Parse(T_Sale_Total.Text);



                if (string.IsNullOrEmpty(T_QuantityCurrent.Text))
                    QuantityCurrent = 0; // الكمية الحالية
                else
                    QuantityCurrent = double.Parse(T_QuantityCurrent.Text);

                if (string.IsNullOrEmpty(T_QuantityRES.Text))
                    QuantityRES = 0; // الكمية المتبقية
                else
                    QuantityRES = double.Parse(T_QuantityRES.Text);


                if (string.IsNullOrEmpty(T_purchasing.Text))
                    purchasing = 0; // شعر الشراء الإفرادي
                else
                    purchasing = double.Parse(T_purchasing.Text);

                if (string.IsNullOrEmpty(T_purchasingTOT.Text))
                    purchasingTOT = 0; // شعر الشراء الإجمالي
                else
                    purchasingTOT = double.Parse(T_purchasingTOT.Text);

                Sale_Total = (Sale_Price * QuantitySales);
                T_Sale_Total.Text = Sale_Total.ToString();

                QuantityRES = (QuantityCurrent - QuantitySales);
                T_QuantityRES.Text = QuantityRES.ToString();

                purchasingTOT = QuantitySales * purchasing;
                T_purchasingTOT.Text = purchasingTOT.ToString();


                if (T_QuantitySales.Text == "")
                {
                    T_Sale_Total.Text = "";
                }

                if (T_QuantitySales.Text == "")
                {
                    T_QuantityRES.Text = "";
                }


                if (T_QuantitySales.Text == "")
                {
                    T_purchasingTOT.Text = "";
                }


                if (QuantitySales > QuantityCurrent)
                    MessageBox.Show("كمية البيع أكبر من كمية المخزون ", "خطأ", MessageBoxButtons.OK);
                if (QuantitySales > QuantityCurrent)
                    T_QuantitySales.Text = null;



            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void T_Vatpercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Vatpercent, VatValue, Sale_Total, AllTotal ,Discount , total1;

                if (string.IsNullOrEmpty(T_Vatpercent.Text))
                    Vatpercent = 0; // نسبة القيمة المضافة
                else
                    Vatpercent = double.Parse(T_Vatpercent.Text);

                if (string.IsNullOrEmpty(T_VatValue.Text))
                    VatValue = 0; // القمية المضافة
                else
                    VatValue = double.Parse(T_VatValue.Text);


                if (string.IsNullOrEmpty(T_Sale_Total.Text))
                    Sale_Total = 0; // السعر الإجمالي
                else
                    Sale_Total = double.Parse(T_Sale_Total.Text);


                if (string.IsNullOrEmpty(T_AllTotal.Text))
                    AllTotal = 0; // المجموع
                else
                    AllTotal = double.Parse(T_AllTotal.Text);


                if (string.IsNullOrEmpty(T_Discount.Text))
                    Discount = 0; // الخصم
                else
                    Discount = double.Parse(T_Discount.Text);


                if (string.IsNullOrEmpty(T_total1.Text))
                    total1 = 0; // إجمالي الأصناف
                else
                    total1 = double.Parse(T_total1.Text);


                VatValue = (total1 * Vatpercent) / 100;
                T_VatValue.Text = VatValue.ToString();


                AllTotal = (total1 + VatValue) - Discount;
                T_AllTotal.Text = AllTotal.ToString();



                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));// قراءة الأرقام
                ToWord toWord = new ToWord(Convert.ToDecimal(T_AllTotal.Text), currencies[0]);
                T_ArabicWords.Text = toWord.ConvertToArabic();
                if (T_AllTotal.Text == "1") // من عندي
                {
                    T_ArabicWords.Text = "واحد";
                }
                if (T_AllTotal.Text.Split('.').Length > 1) // for coma reading
                {
                    T_ArabicWords.Text += " هللة";
                }


                if (T_Vatpercent.Text == "")
                {
                    T_VatValue.Text = "";
                }


                if (T_Vatpercent.Text == "")
                {
                    T_AllTotal.Text = "";
                }

                if (T_Vatpercent.Text == "")
                {
                    T_ArabicWords.Text = "";
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

        private void T_Code_Catg_TextChanged(object sender, EventArgs e)
        {
            if (T_Code_Catg.Text == "")

            T_CatgName.Text = null;
            T_QuantityCurrent.Text = null;
            T_QuantitySales.Text = null;
            T_Sale_Price.Text = null;
            T_Sale_Total.Text = null;
            T_Discount.Text = null;
            T_Vatpercent.Text = null;
            T_VatValue.Text = null;
            T_AllTotal.Text = null;
            T_QuantityRES.Text = null;
            T_Paid.Text = null;
            T_Res.Text = null;
            T_purchasing.Text = null;

            PrintINVC.Enabled = false;
            this.ActiveControl = T_Code_Catg;
        }

        private void PrintINVC_Click(object sender, EventArgs e)
        {
            //  عمل إجراء مخزن - لجلب وعرض البيانات باسم وله كلاس Sale_Ddetails 
            // عمل نفس الإجراء ولكن بدون بارامتر وبدون شروط باسم وهو للطباعة -- وهذا هو الذي نستدعيه من الكريستال وليس له كلاس  Sale_Ddetails_Print    
            // عمل إجراء لجلب آخر رقم أو أخر بيعة باسم وله كلاس Get_Last_Sales 

            //if (dgList.Rows.Count == 0)
            //{
            //    MessageBox.Show("لا يوجد مبيعات", "", MessageBoxButtons.OK);
            //    return;
            //}

            try
            {
                REP.Stores cr = new REP.Stores();// اسم الفورم
                int Invoice = Convert.ToInt32(log.Get_Last_Sale().Rows[0][0]); // استدعاء آخر بيع             
                REP.Sales ORD = new REP.Sales();// اسم الكريستال                                           
                ORD.SetDataSource(log.Sale_Ddetails(Invoice)); // إجراء مخزن للعر ض
                cr.crystalReportViewer1.ReportSource = ORD; // اخفاء الفورم عند الطباعة
              //  cr.Show();

                ORD.PrintToPrinter(1, false, 0, 0);// للطباعة مباشرة دون فتح الصفحة

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(T_Code_Catg.Text) && !string.IsNullOrEmpty(T_CatgName.Text) && !string.IsNullOrEmpty(T_QuantitySales.Text) && !string.IsNullOrEmpty(T_Sale_Total.Text) && !string.IsNullOrEmpty(T_Sale_Price.Text))
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

                dt.Rows.Add(T_Code_Catg.Text, T_CatgName.Text,T_QuantitySales.Text, T_Sale_Price.Text, T_Sale_Total.Text , T_QuantityRES.Text, T_idCAT.Text, T_purchasing.Text, T_purchasingTOT.Text);
                dgList.DataSource = dt;

                T_total1.Text =
        (from DataGridViewRow row in dgList.Rows
         where row.Cells[5].FormattedValue.ToString() != string.Empty
         select Convert.ToDouble(row.Cells["السعر الإجمالي"].FormattedValue)).Sum().ToString();


                T_Code_Catg.Text = null;

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void btn_DELET_Click(object sender, EventArgs e)
        {
            if (dgList.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد مبيعات", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                DialogResult dr = MessageBox.Show(" هل تريد  إلغاء الصنف المحدد ؟ ", "!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //foreach (DataGridViewRow item in this.dgList.SelectedRows) // هذا الحذف لا ينشئ فاتورة جديدة بعد حذف أي مبيع
                    //{
                    //    dgList.Rows.RemoveAt(item.Index); // للحذف يجب تحديد كامل الصف
                    //}

                    foreach (DataGridViewCell oneCell in dgList.SelectedCells) // هذا الحذف لا ينشئ فاتورة جديدة بعد حذف أي مبيع
                    {
                        if (oneCell.Selected)
                            dgList.Rows.RemoveAt(oneCell.RowIndex); //  للحذف على طول بتحديد أي خليفة أو حقل
                    }

                    T_total1.Text =
            (from DataGridViewRow row in dgList.Rows
             where row.Cells[5].FormattedValue.ToString() != string.Empty
             select Convert.ToDouble(row.Cells["السعر الإجمالي"].FormattedValue)).Sum().ToString();

                    T_Discount.Text = null;
                    T_Vatpercent.Text = null;
                    T_VatValue.Text = null;
                    T_AllTotal.Text = null;



                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
