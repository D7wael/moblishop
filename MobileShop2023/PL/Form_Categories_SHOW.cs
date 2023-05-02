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
    public partial class Form_Categories_Zero : Form
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

        public Form_Categories_Zero()
        {
            InitializeComponent();


            T_HijriDate.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));
            T_HijriDate1.Text = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("ar-QR"));

            da = new SqlDataAdapter("select ID_CATG as 'id', Code_Catg as 'رقم الصنف' , CatgName as 'اسم الصنف' , Quantity as 'الكمية' , TMinimum as 'الحد الأدنى للطلب' ,purchasing as 'سعر الشراء الإفرادي' , DTM_Purchasing as 'تاريخ الشراء' , THijriDate as 'تاريخ الشراء هجري', Sale_Price as 'سعر البيع الإفرادي' FROM TB_Categories ", sqlcon);
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

        private void Form_Categories_SHOW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form_Categories_SHOW_Load(object sender, EventArgs e)
        {
            dgList.Sort(dgList.Columns["تاريخ الشراء"], ListSortDirection.Descending); // للعرض من من أحدث تاريخ   

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

        private void btn_DELET_Click(object sender, EventArgs e)
        {
            if (dgList.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد أصناف مدخلة", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                if (MessageBox.Show("هل تريد حذف الصنف المحدد ؟", "الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM TB_Categories WHERE ID_CATG = " + T_id.Text + "", sqlcon);
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

        private void PrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                REP.Stores cr = new REP.Stores();

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

        private void dgList_DoubleClick(object sender, EventArgs e)
        {
            if (dgList.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات أصناف", "", MessageBoxButtons.OK);
                return;
            }

            try
            {

                PL.Form_Categories_CHARG1 CATG = new Form_Categories_CHARG1();

                CATG.T_id.Text = dgList.CurrentRow.Cells[0].Value.ToString();
                CATG.T_Code_Catg.Text = dgList.CurrentRow.Cells[1].Value.ToString();
                CATG.T_CatgName.Text = dgList.CurrentRow.Cells[2].Value.ToString();
                CATG.TQN_Current.Text = dgList.CurrentRow.Cells[3].Value.ToString();
                CATG.T_Minimum.Text = dgList.CurrentRow.Cells[4].Value.ToString();
                CATG.T_purchasing.Text = dgList.CurrentRow.Cells[5].Value.ToString();
                CATG.DTM_Purch1.Text = dgList.CurrentRow.Cells[6].Value.ToString();
                CATG.T_HijriDate.Text = dgList.CurrentRow.Cells[7].Value.ToString();
                CATG.T_Sale_Price.Text = dgList.CurrentRow.Cells[8].Value.ToString();

                CATG.ShowDialog();
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

        }

        private void btn_Shose_Click(object sender, EventArgs e)
        {
            try
            {

                PL.CAT_PIC PIC = new PL.CAT_PIC();
                byte[] image = (byte[])log.GET_IMAGE(this.dgList.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                PIC.pictureBox1.Image = Image.FromStream(ms);
                PIC.ShowDialog();
            }
            catch (System.Exception)
            {
                MessageBox.Show("لم تقم باختيار الصنف ليتم عرض صورته", "حدد الصنف ", MessageBoxButtons.OK);
            }
        }
    }
 }

