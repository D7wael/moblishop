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
    public partial class Form_Sales_SHOW : Form
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

        public Form_Sales_SHOW()
        {
            InitializeComponent();


            T_HijriDate.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));
            T_HijriDate1.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));

            da = new SqlDataAdapter("select ID_INV as 'id', InvoiceNo as 'رقم الفاتورة', SalerName as 'اسم البائع', CustomerName as 'اسم العميل', Phone as 'رقم الجوال', PaymentMethod as 'طريقة الدفع', Code_Catg as 'رقم الصنف' , CatgName as 'اسم الصنف' , QuantitySales as 'الكمية' , Sale_Price as 'السعر الإفرادي' ,Sale_Total as 'السعر الإجمالي' ,Discount as 'الخصم' , Vatpercent as 'نسبة الضريبة %' , VatValue as 'قيمة الضريبة' , AllTotal as 'المجموع' , DTM_Sale as 'تاريخ البيع م' , THijriDate as 'تاريخ البيع هـ', QuantityRES as 'الكمية المتبقية' FROM TB_Sales ", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;

            T_id.DataBindings.Add("text", dt, "id");
            T_InvoiceNo.DataBindings.Add("text", dt, "رقم الفاتورة");
    
            T_Code_Catg.DataBindings.Add("text", dt, "رقم الصنف");

            bmb = this.BindingContext[dt];
            cm = (CurrencyManager)this.BindingContext[dt];
            position.Text = (cm.Position + 1) + " من " + cm.Count;

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

                //if (Dt.Rows[0][2].ToString() == "False" || Dt.Rows[0][2].ToString() == string.Empty)
                //    btn_DELET.Enabled = false;

            }
            catch (Exception)
            {
            }
        }

        private void Form_Sales_SHOW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form_Sales_SHOW_Load(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < dgList.Rows.Count - 1; i++)
                {
                    DataGridViewRow rowToCompare = dgList.Rows[i];
                    for (int otherRow = i + 1; otherRow < dgList.Rows.Count; otherRow++)
                    {
                        DataGridViewRow row = dgList.Rows[otherRow];
                        bool duplicateRow = true;
                        for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                        {
                            if (!rowToCompare.Cells["رقم الفاتورة"].Value.Equals(row.Cells["رقم الفاتورة"].Value))
                            {
                                duplicateRow = false;
                                break;
                            }
                        }
                        if (duplicateRow)
                        {
                            dgList.Rows.Remove(row);
                            otherRow--;
                        }
                    }
                }

            }
            catch (System.Exception)
            {
                //MessageBox.Show(excep.Message);
            }

            dgList.Sort(dgList.Columns["تاريخ البيع م"], ListSortDirection.Descending); // للعرض من من أحدث تاريخ   

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // منع تكبير الفورم

            this.dgList.Columns["id"].Visible = false;
            this.dgList.Columns["اسم البائع"].Visible = false;
            this.dgList.Columns["اسم العميل"].Visible = false;
            this.dgList.Columns["رقم الجوال"].Visible = false;
            this.dgList.Columns["طريقة الدفع"].Visible = false;


            this.dgList.Columns["رقم الصنف"].Visible = false;
            this.dgList.Columns["اسم الصنف"].Visible = false;
            this.dgList.Columns["الكمية"].Visible = false;
            this.dgList.Columns["السعر الإفرادي"].Visible = false;
            this.dgList.Columns["السعر الإجمالي"].Visible = false;
            this.dgList.Columns["الخصم"].Visible = false;
            this.dgList.Columns["نسبة الضريبة %"].Visible = false;
            this.dgList.Columns["قيمة الضريبة"].Visible = false;
            this.dgList.Columns["الكمية المتبقية"].Visible = false;

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
            this.dgList.Columns["المجموع"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["تاريخ البيع م"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["تاريخ البيع هـ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["الكمية المتبقية"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            T_Total.Text =
     (from DataGridViewRow row in dgList.Rows
      where row.Cells[15].FormattedValue.ToString() != string.Empty
      select Convert.ToDouble(row.Cells["المجموع"].FormattedValue)).Sum().ToString();

            
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
            position.Text = (cm.Position + 1) + " من " + cm.Count;
        }

        private void dgList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            position.Text = (cm.Position + 1) + " من " + cm.Count;
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void T_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dt.Clear();
                da = new SqlDataAdapter(@"select 
                    ID_INV as 'id',
                    InvoiceNo as 'رقم الفاتورة',
                    SalerName as 'اسم البائع',
                    CustomerName as 'اسم العميل', 
                    Phone as 'رقم الجوال',
                    PaymentMethod as 'طريقة الدفع',
                    Code_Catg as 'رقم الصنف' , 
                    CatgName as 'اسم الصنف' , 
                    QuantitySales as 'الكمية' ,
                    Sale_Price as 'السعر الإفرادي' ,
                    Sale_Total as 'السعر الإجمالي' ,
                    Discount as 'الخصم' , 
                    Vatpercent as 'نسبة الضريبة %' ,
                    VatValue as 'قيمة الضريبة' ,
                    AllTotal as 'المجموع' ,
                    DTM_Sale as 'تاريخ البيع م' ,
                    THijriDate as 'تاريخ البيع هـ',
                    QuantityRES as 'الكمية المتبقية'
                    FROM TB_Sales 
              
                WHERE
                Code_Catg + CatgName + SalerName + CustomerName + Phone + PaymentMethod +
                CONVERT (varchar, ID_INV) +
                CONVERT (varchar, InvoiceNo) +
                CONVERT (varchar, QuantitySales) +
                CONVERT (varchar, Sale_Price) +            
                CONVERT (varchar,Sale_Total) +
                CONVERT (varchar,Discount) +
                CONVERT (varchar,Vatpercent) +
                CONVERT (varchar,VatValue) +
                CONVERT (varchar,AllTotal) +
                CONVERT (varchar,DTM_Sale) +
                CONVERT (varchar,THijriDate) +
                CONVERT (varchar,QuantityRES)               

                like '%" + T_Search.Text + "%' ", sqlcon);
                da.Fill(dt);
                dgList.DataSource = dt;

                for (int i = 0; i < dgList.Rows.Count - 1; i++)
                {
                    DataGridViewRow rowToCompare = dgList.Rows[i];
                    for (int otherRow = i + 1; otherRow < dgList.Rows.Count; otherRow++)
                    {
                        DataGridViewRow row = dgList.Rows[otherRow];
                        bool duplicateRow = true;
                        for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                        {
                            if (!rowToCompare.Cells["رقم الفاتورة"].Value.Equals(row.Cells["رقم الفاتورة"].Value))
                            {
                                duplicateRow = false;
                                break;
                            }
                        }
                        if (duplicateRow)
                        {
                            dgList.Rows.Remove(row);
                            otherRow--;
                        }
                    }
                }

                position.Text = (cm.Position + 1) + " من " + cm.Count;


            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

            T_Total.Text =
        (from DataGridViewRow row in dgList.Rows
         where row.Cells[15].FormattedValue.ToString() != string.Empty
         select Convert.ToDouble(row.Cells["المجموع"].FormattedValue)).Sum().ToString();
           
        }

        private void T_Reset_Click(object sender, EventArgs e)
        {
            date2.Value = DateTime.Now;
            date1.Value = DateTime.Now;
            T_HijriDate.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));
            T_HijriDate1.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));

            try
            {
                dt.Clear();
                da = new SqlDataAdapter("select ID_INV as 'id', InvoiceNo as 'رقم الفاتورة', SalerName as 'اسم البائع', CustomerName as 'اسم العميل', Phone as 'رقم الجوال', PaymentMethod as 'طريقة الدفع', Code_Catg as 'رقم الصنف' , CatgName as 'اسم الصنف' , QuantitySales as 'الكمية' , Sale_Price as 'السعر الإفرادي' ,Sale_Total as 'السعر الإجمالي' ,Discount as 'الخصم' , Vatpercent as 'نسبة الضريبة %' , VatValue as 'قيمة الضريبة' , AllTotal as 'المجموع' , DTM_Sale as 'تاريخ البيع م' , THijriDate as 'تاريخ البيع هـ', QuantityRES as 'الكمية المتبقية' FROM TB_Sales ", sqlcon);
                da.Fill(dt);
                dgList.DataSource = dt;

                for (int i = 0; i < dgList.Rows.Count - 1; i++)
                {
                    DataGridViewRow rowToCompare = dgList.Rows[i];
                    for (int otherRow = i + 1; otherRow < dgList.Rows.Count; otherRow++)
                    {
                        DataGridViewRow row = dgList.Rows[otherRow];
                        bool duplicateRow = true;
                        for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                        {
                            if (!rowToCompare.Cells["رقم الفاتورة"].Value.Equals(row.Cells["رقم الفاتورة"].Value))
                            {
                                duplicateRow = false;
                                break;
                            }
                        }
                        if (duplicateRow)
                        {
                            dgList.Rows.Remove(row);
                            otherRow--;
                        }
                    }
                }

                position.Text = (cm.Position + 1) + " من " + cm.Count;

                T_Search.Text = null;


                T_Total.Text =
  (from DataGridViewRow row in dgList.Rows
   where row.Cells[15].FormattedValue.ToString() != string.Empty
   select Convert.ToDouble(row.Cells["المجموع"].FormattedValue)).Sum().ToString();

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            T_HijriDate.Text = date1.Value.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));

            try
            {
                dt.Clear();
                da = new SqlDataAdapter(@"select 
                    ID_INV as 'id',
                    InvoiceNo as 'رقم الفاتورة',
                    SalerName as 'اسم البائع',
                    CustomerName as 'اسم العميل', 
                    Phone as 'رقم الجوال',
                    PaymentMethod as 'طريقة الدفع',
                    Code_Catg as 'رقم الصنف' , 
                    CatgName as 'اسم الصنف' , 
                    QuantitySales as 'الكمية' ,
                    Sale_Price as 'السعر الإفرادي' ,
                    Sale_Total as 'السعر الإجمالي' ,
                    Discount as 'الخصم' , 
                    Vatpercent as 'نسبة الضريبة %' ,
                    VatValue as 'قيمة الضريبة' ,
                    AllTotal as 'المجموع' ,
                    DTM_Sale as 'تاريخ البيع م' ,
                    THijriDate as 'تاريخ البيع هـ',
                    QuantityRES as 'الكمية المتبقية' 

                    FROM TB_Sales               
                    WHERE DTM_Sale BETWEEN '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd") + "   '", sqlcon);

                da.Fill(dt);
                dgList.DataSource = dt;

                for (int i = 0; i < dgList.Rows.Count - 1; i++)
                {
                    DataGridViewRow rowToCompare = dgList.Rows[i];
                    for (int otherRow = i + 1; otherRow < dgList.Rows.Count; otherRow++)
                    {
                        DataGridViewRow row = dgList.Rows[otherRow];
                        bool duplicateRow = true;
                        for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                        {
                            if (!rowToCompare.Cells["رقم الفاتورة"].Value.Equals(row.Cells["رقم الفاتورة"].Value))
                            {
                                duplicateRow = false;
                                break;
                            }
                        }
                        if (duplicateRow)
                        {
                            dgList.Rows.Remove(row);
                            otherRow--;
                        }
                    }
                }

                position.Text = (cm.Position + 1) + " / " + cm.Count;

                T_Total.Text =
(from DataGridViewRow row in dgList.Rows
where row.Cells[15].FormattedValue.ToString() != string.Empty
select Convert.ToDouble(row.Cells["المجموع"].FormattedValue)).Sum().ToString();

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            T_HijriDate1.Text = date2.Value.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));

            try
            {
                dt.Clear();
                da = new SqlDataAdapter(@"select 
                    ID_INV as 'id',
                    InvoiceNo as 'رقم الفاتورة',
                    SalerName as 'اسم البائع',
                    CustomerName as 'اسم العميل', 
                    Phone as 'رقم الجوال',
                    PaymentMethod as 'طريقة الدفع',
                    Code_Catg as 'رقم الصنف' , 
                    CatgName as 'اسم الصنف' , 
                    QuantitySales as 'الكمية' ,
                    Sale_Price as 'السعر الإفرادي' ,
                    Sale_Total as 'السعر الإجمالي' ,
                    Discount as 'الخصم' , 
                    Vatpercent as 'نسبة الضريبة %' ,
                    VatValue as 'قيمة الضريبة' ,
                    AllTotal as 'المجموع' ,
                    DTM_Sale as 'تاريخ البيع م' ,
                    THijriDate as 'تاريخ البيع هـ',
                    QuantityRES as 'الكمية المتبقية' 

                    FROM TB_Sales               
                    WHERE DTM_Sale BETWEEN '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd") + "   '", sqlcon);

                da.Fill(dt);
                dgList.DataSource = dt;

                for (int i = 0; i < dgList.Rows.Count - 1; i++)
                {
                    DataGridViewRow rowToCompare = dgList.Rows[i];
                    for (int otherRow = i + 1; otherRow < dgList.Rows.Count; otherRow++)
                    {
                        DataGridViewRow row = dgList.Rows[otherRow];
                        bool duplicateRow = true;
                        for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                        {
                            if (!rowToCompare.Cells["رقم الفاتورة"].Value.Equals(row.Cells["رقم الفاتورة"].Value))
                            {
                                duplicateRow = false;
                                break;
                            }
                        }
                        if (duplicateRow)
                        {
                            dgList.Rows.Remove(row);
                            otherRow--;
                        }
                    }
                }

                position.Text = (cm.Position + 1) + " / " + cm.Count;

                T_Total.Text =
(from DataGridViewRow row in dgList.Rows
 where row.Cells[15].FormattedValue.ToString() != string.Empty
 select Convert.ToDouble(row.Cells["المجموع"].FormattedValue)).Sum().ToString();

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void PrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                REP.Stores cr = new REP.Stores();
                da = new SqlDataAdapter(@"select * FROM TB_Sales WHERE InvoiceNo ='" + T_InvoiceNo.Text.ToString() + "'", sqlcon);
                DataSet ds = new DataSet();
                da.Fill(ds, "TB_Sales");
                REP.Sales ORD = new REP.Sales();  // اسم الكريستال
                ORD.SetDataSource(ds.Tables["TB_Sales"]);
                cr.crystalReportViewer1.ReportSource = ORD;
                cr.Show();

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void dgList_DoubleClick(object sender, EventArgs e)
        {
            if (dgList.Rows.Count == 0)
            {
                MessageBox.Show(" لا توجد فواتير مبيعات", "", MessageBoxButtons.OK);
                return;
            }

            try
            {

                Form_Sales_SHOW1 SAL1 = new PL.Form_Sales_SHOW1();

                SAL1.T_InvoiceNo.Text = this.T_InvoiceNo.Text;
                SAL1.T_id.Text = dgList.CurrentRow.Cells["id"].Value.ToString();
                SAL1.T_InvoiceNo.Text = dgList.CurrentRow.Cells["رقم الفاتورة"].Value.ToString();


                //this.Hide();
                SAL1.ShowDialog();
                //this.Close();
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
    }
}
