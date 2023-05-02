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
    public partial class Form_Spents_SHOW : Form
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

        public Form_Spents_SHOW()
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

        private void Form_Spents_SHOW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form_Spents_SHOW_Load(object sender, EventArgs e)
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

        private void btn_DELET_Click(object sender, EventArgs e)
        {
            if (dgList.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد مصروفات مدخلة", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                if (MessageBox.Show("هل تريد حذف المصروف المحدد ؟", "الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM TB_SPENTS WHERE ID_Dpent = " + T_id.Text + "", sqlcon);
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("تم الحذف بنجاج  ", " الحذف ");
                    cm.RemoveAt(cm.Position);
                    da.Update(dt);

                }
                else
                    MessageBox.Show("تم إلغاء الحذف");
            }
            catch (System.Exception)
            {
                //MessageBox.Show(excep.Message); // تم تعطيله ليتم تحديث الحذف مباشرة
            }
            sqlcon.Close();
            position.Text = (cm.Position + 1) + " من " + cm.Count;

            T_SpentPrice.Text =
           (from DataGridViewRow row in dgList.Rows
            where row.Cells[2].FormattedValue.ToString() != string.Empty
            select Convert.ToDouble(row.Cells["قيمة المصروف"].FormattedValue)).Sum().ToString();

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
