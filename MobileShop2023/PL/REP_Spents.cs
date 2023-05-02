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
    public partial class REP_Spents : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        CurrencyManager cm;
        BindingManagerBase bmb;

        BL.ALLPrograms log = new BL.ALLPrograms();
        public string currentUser = Login.Frm_login.UserInformation.CurrentLoggedInUser; // لعرض اسم المستخدم الحالي
                                                                                         // اضغط على الخيار الأول فيتم استدعاء مكتبة الأرقام بعد إضافة كلاس توورد وكلاس كرنسي انفو أيضاً 
        List<CurrencyInfo> currencies = new List<CurrencyInfo>(); // لتحويل الأرقام

        public REP_Spents()
        {
            InitializeComponent();

            T_HijriDate.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));
            T_HijriDate1.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));

            da = new SqlDataAdapter("select ID_Dpent as 'id', SpentKind as 'نوع المصروف', SpentPrice as 'قيمة المصروف' , DTMSpent as 'التاريخ' , THijriDate as 'تاريخ هـ'  , Name as 'الاسم' FROM TB_SPENTS ", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;

            T_id.DataBindings.Add("text", dt, "id");

            bmb = this.BindingContext[dt];
            cm = (CurrencyManager)this.BindingContext[dt];
            position.Text = (cm.Position + 1) + " من " + cm.Count;
        }

        private void REP_Spents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void REP_Spents_Load(object sender, EventArgs e)
        {
            dgList.Sort(dgList.Columns["التاريخ"], ListSortDirection.Descending); // للعرض من من أحدث تاريخ   

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // منع تكبير الفورم

            this.dgList.Columns["id"].Visible = false;

            foreach (DataGridViewColumn col in dgList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            }


            this.dgList.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["نوع المصروف"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["قيمة المصروف"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["التاريخ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["تاريخ هـ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgList.Columns["الاسم"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            try
            {

                T_SpentPrice.Text =
              (from DataGridViewRow row in dgList.Rows
               where row.Cells[2].FormattedValue.ToString() != string.Empty
               select Convert.ToDouble(row.Cells["قيمة المصروف"].FormattedValue)).Sum().ToString();


                //T_Profits.Text = (Double.Parse(T_SalesTOT.Text) + Double.Parse(T_VatValue.Text) - Double.Parse(T_purchasingTOT.Text)).ToString();
                //T_Profit.Text = (Double.Parse(T_TOTAL.Text) - Double.Parse(T_Total_Purchase.Text) - Double.Parse(T_Discount.Text)).ToString();

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

        private void T_Reset_Click(object sender, EventArgs e)
        {
            date2.Value = DateTime.Now;
            date1.Value = DateTime.Now;
            T_HijriDate.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));
            T_HijriDate1.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));

            try
            {
                dt.Clear();
                da = new SqlDataAdapter("select ID_Dpent as 'id', SpentKind as 'نوع المصروف', SpentPrice as 'قيمة المصروف' , DTMSpent as 'التاريخ' , THijriDate as 'تاريخ هـ'  , Name as 'الاسم' FROM TB_SPENTS ", sqlcon);
                da.Fill(dt);
                dgList.DataSource = dt;

                position.Text = (cm.Position + 1) + " من " + cm.Count;

                T_SpentPrice.Text =
              (from DataGridViewRow row in dgList.Rows
               where row.Cells[2].FormattedValue.ToString() != string.Empty
               select Convert.ToDouble(row.Cells["قيمة المصروف"].FormattedValue)).Sum().ToString();

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
                    ID_Dpent as 'id',
                    SpentKind as 'نوع المصروف', 
                    SpentPrice as 'قيمة المصروف' ,
                    DTMSpent as 'التاريخ' ,
                    THijriDate as 'تاريخ هـ'  ,
                    Name as 'الاسم' 
                    FROM TB_SPENTS 
                    WHERE DTMSpent BETWEEN '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd") + "   '", sqlcon);

                da.Fill(dt);
                dgList.DataSource = dt;

                position.Text = (cm.Position + 1) + " / " + cm.Count;

                T_SpentPrice.Text =
              (from DataGridViewRow row in dgList.Rows
               where row.Cells[2].FormattedValue.ToString() != string.Empty
               select Convert.ToDouble(row.Cells["قيمة المصروف"].FormattedValue)).Sum().ToString();


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
                    ID_Dpent as 'id',
                    SpentKind as 'نوع المصروف', 
                    SpentPrice as 'قيمة المصروف' ,
                    DTMSpent as 'التاريخ' ,
                    THijriDate as 'تاريخ هـ'  ,
                    Name as 'الاسم' 
                    FROM TB_SPENTS 
                    WHERE DTMSpent BETWEEN '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd") + "   '", sqlcon);

                da.Fill(dt);
                dgList.DataSource = dt;

                position.Text = (cm.Position + 1) + " / " + cm.Count;

                T_SpentPrice.Text =
              (from DataGridViewRow row in dgList.Rows
               where row.Cells[2].FormattedValue.ToString() != string.Empty
               select Convert.ToDouble(row.Cells["قيمة المصروف"].FormattedValue)).Sum().ToString();

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
                da = new SqlDataAdapter(@"select * FROM TB_SPENTS ", sqlcon);
                DataSet ds = new DataSet();
                da.Fill(ds, "TB_SPENTS");
                REP.SPENTS ORD = new REP.SPENTS();  // اسم الكريستال
                ORD.SetDataSource(ds.Tables["TB_SPENTS"]);
                cr.crystalReportViewer1.ReportSource = ORD;
                cr.Show();

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
                da = new SqlDataAdapter(@"select * FROM TB_SPENTS                
                                  WHERE DTMSpent BETWEEN '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd") + "'   ", sqlcon);
                DataSet ds = new DataSet();
                da.Fill(ds, "TB_SPENTS");
                REP.SPENTS ORD = new REP.SPENTS();  // اسم الكريستال
                ORD.SetDataSource(ds.Tables["TB_SPENTS"]);
                cr.crystalReportViewer1.ReportSource = ORD;
                cr.Show();

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void T_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dt.Clear();
                da = new SqlDataAdapter(@"select
                    ID_Dpent as 'id',
                    SpentKind as 'نوع المصروف', 
                    SpentPrice as 'قيمة المصروف' ,
                    DTMSpent as 'التاريخ' ,
                    THijriDate as 'تاريخ هـ'  ,
                    Name as 'الاسم' 
                    FROM TB_SPENTS 
              
                WHERE
                SpentKind + Name +
                CONVERT (varchar, ID_Dpent) +
                CONVERT (varchar, SpentPrice) +
                CONVERT (varchar, DTMSpent) +
                CONVERT (varchar, THijriDate)             
        
                like '%" + T_Search.Text + "%' ", sqlcon);
                da.Fill(dt);
                dgList.DataSource = dt;

                position.Text = (cm.Position + 1) + " من " + cm.Count;

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

            T_SpentPrice.Text =
                     (from DataGridViewRow row in dgList.Rows
                      where row.Cells[2].FormattedValue.ToString() != string.Empty
                      select Convert.ToDouble(row.Cells["قيمة المصروف"].FormattedValue)).Sum().ToString();

        }
    }
}
