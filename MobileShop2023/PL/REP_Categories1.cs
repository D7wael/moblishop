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
    public partial class REP_Categories1 : Form
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

        public REP_Categories1()
        {
            InitializeComponent();


            T_HijriDate.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));
            T_HijriDate1.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));

            da = new SqlDataAdapter("select ID_CATG as 'id', Code_Catg as 'رقم الصنف' , CatgName as 'اسم الصنف', Quantity as 'الكمية' , TMinimum as 'الحد الأدنى للطلب' ,purchasing as 'سعر الشراء الإفرادي' , DTM_Purchasing as 'تاريخ الشراء' , THijriDate as 'تاريخ الشراء هجري', Sale_Price as 'سعر البيع الإفرادي' FROM TB_Categories ", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;

            T_id.DataBindings.Add("text", dt, "id");


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

        private void REP_Categories1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void REP_Categories1_Load(object sender, EventArgs e)
        {
            dgList.Sort(dgList.Columns["تاريخ الشراء"], ListSortDirection.Descending); // للعرض من من أحدث تاريخ   
            PrintAll.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // منع تكبير الفورم

            this.dgList.Columns["id"].Visible = false;

            this.dgList.Columns["سعر الشراء الإفرادي"].Visible = false;
            this.dgList.Columns["سعر البيع الإفرادي"].Visible = false;

            foreach (DataGridViewColumn col in dgList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            }


            this.dgList.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["رقم الصنف"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["اسم الصنف"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["الكمية"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["الحد الأدنى للطلب"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["سعر الشراء الإفرادي"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["تاريخ الشراء"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["تاريخ الشراء هجري"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["سعر البيع الإفرادي"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
                da = new SqlDataAdapter(@"select ID_CATG as 'id',
                    Code_Catg as 'رقم الصنف' ,
                    CatgName as 'اسم الصنف' ,
                    Quantity as 'الكمية' ,
                    TMinimum as 'الحد الأدنى للطلب' ,
                    purchasing as 'سعر الشراء الإفرادي' ,
                    DTM_Purchasing as 'تاريخ الشراء' ,
                    THijriDate as 'تاريخ الشراء هجري',
                    Sale_Price as 'سعر البيع الإفرادي' 

                    FROM TB_Categories 
           
                WHERE
                Code_Catg + CatgName +
                CONVERT (varchar, ID_CATG) +
                CONVERT (varchar, Quantity) +
                CONVERT (varchar, TMinimum) +            
                CONVERT (varchar,purchasing) +
                CONVERT (varchar,DTM_Purchasing) +
                CONVERT (varchar,THijriDate) +
                CONVERT (varchar,Sale_Price) 

                like '%" + T_Search.Text + "%' ", sqlcon);
                da.Fill(dt);
                dgList.DataSource = dt;

                position.Text = (cm.Position + 1) + " من " + cm.Count;


            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

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
                da = new SqlDataAdapter("select ID_CATG as 'id', Code_Catg as 'رقم الصنف' , CatgName as 'اسم الصنف' , Quantity as 'الكمية' , TMinimum as 'الحد الأدنى للطلب' ,purchasing as 'سعر الشراء الإفرادي' , DTM_Purchasing as 'تاريخ الشراء' , THijriDate as 'تاريخ الشراء هجري', Sale_Price as 'سعر البيع الإفرادي' FROM TB_Categories ", sqlcon);
                da.Fill(dt);
                dgList.DataSource = dt;
                position.Text = (cm.Position + 1) + " من " + cm.Count;

                T_Search.Text = null;

                checkBox_Yes.Checked = false;
                checkBox_NO.Checked = false;
                checkBox_ALL.Checked = false;

                PrintAll.Enabled = false;

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
                da = new SqlDataAdapter(@"select ID_CATG as 'id',
                    Code_Catg as 'رقم الصنف' ,
                    CatgName as 'اسم الصنف' ,
                    Quantity as 'الكمية' ,
                    TMinimum as 'الحد الأدنى للطلب' ,
                    purchasing as 'سعر الشراء الإفرادي' ,
                    DTM_Purchasing as 'تاريخ الشراء' ,
                    THijriDate as 'تاريخ الشراء هجري',
                    Sale_Price as 'سعر البيع الإفرادي' 

                    FROM TB_Categories               
                    WHERE DTM_Purchasing BETWEEN '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd") + "   '", sqlcon);

                da.Fill(dt);
                dgList.DataSource = dt;
                position.Text = (cm.Position + 1) + " / " + cm.Count;

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
                da = new SqlDataAdapter(@"select ID_CATG as 'id',
                    Code_Catg as 'رقم الصنف' ,
                    CatgName as 'اسم الصنف' ,
                    Quantity as 'الكمية' ,
                    TMinimum as 'الحد الأدنى للطلب' ,
                    purchasing as 'سعر الشراء الإفرادي' ,
                    DTM_Purchasing as 'تاريخ الشراء' ,
                    THijriDate as 'تاريخ الشراء هجري',
                    Sale_Price as 'سعر البيع الإفرادي' 

                    FROM TB_Categories               
                    WHERE DTM_Purchasing BETWEEN '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd") + "   '", sqlcon);

                da.Fill(dt);
                dgList.DataSource = dt;
                position.Text = (cm.Position + 1) + " / " + cm.Count;

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void Print2Dates_Click(object sender, EventArgs e)
        {
            try
            {
                REP.Stores cr = new REP.Stores();
                da = new SqlDataAdapter(@"select * FROM TB_Categories                
                                  WHERE DTM_Purchasing BETWEEN '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd") + "'   ", sqlcon);
                DataSet ds = new DataSet();
                da.Fill(ds, "TB_Categories");
                REP.Categories ORD = new REP.Categories();  // اسم الكريستال
                ORD.SetDataSource(ds.Tables["TB_Categories"]);
                cr.crystalReportViewer1.ReportSource = ORD;
                cr.Show();

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

                if (checkBox_ALL.Checked == true)
                {

                    da = new SqlDataAdapter(@"select * FROM TB_Categories                
                WHERE
                Code_Catg + CatgName +
                CONVERT (varchar, ID_CATG) +
                CONVERT (varchar, Quantity) +
                CONVERT (varchar, TMinimum) +            
                CONVERT (varchar,purchasing) +
                CONVERT (varchar,DTM_Purchasing) +
                CONVERT (varchar,THijriDate) +
                CONVERT (varchar,Sale_Price) 

                like '%" + T_Search.Text + "%' ", sqlcon);
                }

                if (checkBox_NO.Checked == true)
                {
                da = new SqlDataAdapter(@"select * FROM TB_Categories                
                WHERE
                   Code_Catg + CatgName +
                CONVERT (varchar, ID_CATG) +
                CONVERT (varchar, Quantity) +
                CONVERT (varchar, TMinimum) +            
                CONVERT (varchar,purchasing) +
                CONVERT (varchar,DTM_Purchasing) +
                CONVERT (varchar,THijriDate) +
                CONVERT (varchar,Sale_Price) 

                like '%" + T_Search.Text + "%'  and Quantity <= TMinimum  and Quantity !=0 ", sqlcon);
                }
                if (checkBox_Yes.Checked == true)
                {
                da = new SqlDataAdapter(@"select * FROM TB_Categories                
                WHERE
                  Code_Catg + CatgName +
                CONVERT (varchar, ID_CATG) +
                CONVERT (varchar, Quantity) +
                CONVERT (varchar, TMinimum) +            
                CONVERT (varchar,purchasing) +
                CONVERT (varchar,DTM_Purchasing) +
                CONVERT (varchar,THijriDate) +
                CONVERT (varchar,Sale_Price) 

                like '%" + T_Search.Text + "%'  and Quantity =0 ", sqlcon);
                }
                DataSet ds = new DataSet();
                da.Fill(ds, "TB_Categories");
                REP.Categories1 ORD = new REP.Categories1();  // اسم الكريستال
                ORD.SetDataSource(ds.Tables["TB_Categories"]);
                cr.crystalReportViewer1.ReportSource = ORD;
                cr.Show();
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void checkBox_ALL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ALL.Checked == true)
            {
                PrintAll.Enabled = true;
                checkBox_Yes.Checked = false;
                checkBox_NO.Checked = false;
            }

            try
            {
                dt.Clear();
                da = new SqlDataAdapter("select ID_CATG as 'id', Code_Catg as 'رقم الصنف' , CatgName as 'اسم الصنف' , Quantity as 'الكمية' , TMinimum as 'الحد الأدنى للطلب' ,purchasing as 'سعر الشراء الإفرادي' , DTM_Purchasing as 'تاريخ الشراء' , THijriDate as 'تاريخ الشراء هجري', Sale_Price as 'سعر البيع الإفرادي' FROM TB_Categories ", sqlcon);
                da.Fill(dt);
                dgList.DataSource = dt;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

            if (checkBox_ALL.Checked == false)
            {
                dt.Clear();
            }
        }

        private void checkBox_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Yes.Checked == true)
            {
                PrintAll.Enabled = true;
                checkBox_NO.Checked = false;
                checkBox_ALL.Checked = false;
            }
          
            try
            {
                dt.Clear();
                da = new SqlDataAdapter("select ID_CATG as 'id', Code_Catg as 'رقم الصنف' , CatgName as 'اسم الصنف' , Quantity as 'الكمية' , TMinimum as 'الحد الأدنى للطلب' ,purchasing as 'سعر الشراء الإفرادي' , DTM_Purchasing as 'تاريخ الشراء' , THijriDate as 'تاريخ الشراء هجري', Sale_Price as 'سعر البيع الإفرادي' FROM TB_Categories WHERE Quantity  = 0 ", sqlcon);

                da.Fill(dt);
                dgList.DataSource = dt;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

            if (checkBox_Yes.Checked == false)
            {
                dt.Clear();
            }
        }

        private void checkBox_NO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_NO.Checked == true)
            {
                PrintAll.Enabled = true;
                checkBox_Yes.Checked = false;
                checkBox_ALL.Checked = false;
            }

            try
            {
                dt.Clear();
                da = new SqlDataAdapter("select ID_CATG as 'id', Code_Catg as 'رقم الصنف' , CatgName as 'اسم الصنف' , Quantity as 'الكمية' , TMinimum as 'الحد الأدنى للطلب' ,purchasing as 'سعر الشراء الإفرادي' , DTM_Purchasing as 'تاريخ الشراء' , THijriDate as 'تاريخ الشراء هجري', Sale_Price as 'سعر البيع الإفرادي' FROM TB_Categories WHERE Quantity <= TMinimum  and Quantity !=0 ", sqlcon);

                da.Fill(dt);
                dgList.DataSource = dt;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

            if (checkBox_NO.Checked == false)
            {
                dt.Clear();
            }
        }

        private void dgList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i <= dgList.Rows.Count - 1; i++)
            {
                if (dgList.Rows[i].Cells["الكمية"].Value.ToString() == '0'.ToString())
                {
                    dgList.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
    }
}
