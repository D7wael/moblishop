using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MobileShop2023.Login
{
    public partial class Frm_Priv_user : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        SqlDataAdapter Da;
        DataTable Dts = new DataTable();
        public Frm_Priv_user()
        {
            InitializeComponent();

            LoadData();
        }
        void LoadData()
        {
            DataTable Dt = new DataTable();
            DataTable Dt2 = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select * from TB_Users", sqlcon);
            Da.Fill(Dt);

            list_user.DataSource = Dt;
            list_user.DisplayMember = "User_name";
            list_user.ValueMember = "User_ID";

            SqlDataAdapter Da2 = new SqlDataAdapter("select * from TB_Lists", sqlcon);
            Da2.Fill(Dt2);
            list_showlist.DataSource = Dt2;
            list_showlist.DisplayMember = "List_name";
            list_showlist.ValueMember = "List_ID";
        }
        private void Frm_Priv_user_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;//  منع الفورم من التكبير بالفارة
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labels.Left = labels.Left - 5;
            if (labels.Left < 0 - groupBox1.Width)
            {
                labels.Left = groupBox1.Width;
            }
        }

        private void list_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Dts.Clear();
                Da = new SqlDataAdapter("select TB_Priv.Priv_Screen_ID, Screen_name,Priv_User_ID, Priv_Display, Priv_Add, Priv_Edit, Priv_Delete from TB_Priv,TB_screens  where  TB_Priv.Priv_Screen_ID=TB_screens.Screen_ID and TB_screens.list_ID=(select List_ID from TB_lists where List_ID= " + list_showlist.SelectedValue + ")    and Priv_User_ID= " + list_user.SelectedValue + "", sqlcon);

                Da.Fill(Dts);
                dataGridView1.DataSource = Dts;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[1].HeaderText = "اسـم الواجهة";
                dataGridView1.Columns[3].HeaderText = "عرض الواجهة";  // Priv_Display
                dataGridView1.Columns[4].HeaderText = "حفظ"; // Priv_Add
                dataGridView1.Columns[5].HeaderText = "تـعـديل";  // Priv_Edit
                dataGridView1.Columns[6].HeaderText = "حـذف";  // Priv_Delete
                dataGridView1.Columns[2].ReadOnly = true;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void butn_Save_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(list_user.SelectedValue);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int Screen_No = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                Boolean Dis = dataGridView1.Rows[i].Cells[3].Value.Equals(true || false);
                Boolean Add = dataGridView1.Rows[i].Cells[4].Value.Equals(true || false);
                Boolean edit = dataGridView1.Rows[i].Cells[5].Value.Equals(true || false);
                Boolean delete = dataGridView1.Rows[i].Cells[6].Value.Equals(true || false);

                SqlCommand cmd = new SqlCommand(" UPDATE TB_Priv SET  Priv_Display=@Priv_Display, Priv_Add=@Priv_Add,Priv_Edit=@Priv_Edit ,Priv_Delete=@Priv_Delete where Priv_User_ID=@User_ID and Priv_Screen_ID=@Screen_ID ", sqlcon);
                cmd.Parameters.Add(new SqlParameter("@Priv_Display", SqlDbType.Bit)).Value = Dis;
                cmd.Parameters.Add(new SqlParameter("@Priv_Add", SqlDbType.Bit)).Value = Add;
                cmd.Parameters.Add(new SqlParameter("@Priv_Edit", SqlDbType.Bit)).Value = edit;
                cmd.Parameters.Add(new SqlParameter("@Priv_Delete", SqlDbType.Bit)).Value = delete;
                cmd.Parameters.Add(new SqlParameter("@User_ID", SqlDbType.Int)).Value = userId;
                cmd.Parameters.Add(new SqlParameter("@Screen_ID", SqlDbType.Int)).Value = Screen_No;

                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                //btn_can_Click(sender, e);

            }
            MessageBox.Show("تم التعديل");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void list_showlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Dts.Clear();
                Da = new SqlDataAdapter("select TB_Priv.Priv_Screen_ID,  Screen_name, Priv_User_ID,  Priv_Display, Priv_Add,  Priv_Edit, Priv_Delete from TB_Priv, TB_screens where  TB_Priv.Priv_Screen_ID=TB_screens.Screen_ID and TB_screens.list_ID=(select List_ID from TB_lists where List_ID= " + list_showlist.SelectedValue + ")    and Priv_User_ID= " + list_user.SelectedValue + "", sqlcon);

                Da.Fill(Dts);
                dataGridView1.DataSource = Dts;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[1].HeaderText = "اسـم الواجهة";
                dataGridView1.Columns[3].HeaderText = "عرض الواجهة";  // Priv_Display
                dataGridView1.Columns[4].HeaderText = "حفظ"; // Priv_Add
                dataGridView1.Columns[5].HeaderText = "تـعـديل";  // Priv_Edit
                dataGridView1.Columns[6].HeaderText = "حـذف";  // Priv_Delete
                dataGridView1.Columns[2].ReadOnly = true;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            int index = list_user.FindString(txt_search.Text, -1);
            if (index != -1)
                list_user.SetSelected(index, true);
            else
                MessageBox.Show("القيمة غير موجودة");

            if (index == -1)
                txt_search.Text = null;
        }

        private void butn_SelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                // خطير في تحديد الكل من الداتا جرير
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell chk3 = (DataGridViewCheckBoxCell)row.Cells[3];
                    DataGridViewCheckBoxCell chk4 = (DataGridViewCheckBoxCell)row.Cells[4];
                    DataGridViewCheckBoxCell chk5 = (DataGridViewCheckBoxCell)row.Cells[5];
                    DataGridViewCheckBoxCell chk6 = (DataGridViewCheckBoxCell)row.Cells[6];

                    chk3.Value = !(chk3.Value != null ? false : (bool)chk3.Value.Equals(true));
                    chk4.Value = !(chk4.Value != null ? false : (bool)chk4.Value.Equals(true));
                    chk5.Value = !(chk5.Value != null ? false : (bool)chk5.Value.Equals(true));
                    chk6.Value = !(chk6.Value != null ? false : (bool)chk6.Value.Equals(true));
                }
            }
            catch (Exception)
            {
            }
        }

        private void butn_UnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                // خطير في إلغاء الكل من الداتا جرير
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell chk3 = (DataGridViewCheckBoxCell)row.Cells[3];
                    DataGridViewCheckBoxCell chk4 = (DataGridViewCheckBoxCell)row.Cells[4];
                    DataGridViewCheckBoxCell chk5 = (DataGridViewCheckBoxCell)row.Cells[5];
                    DataGridViewCheckBoxCell chk6 = (DataGridViewCheckBoxCell)row.Cells[6];

                    chk3.Value = !(chk3.Value != null ? true : (bool)chk3.Value.Equals(false));
                    chk4.Value = !(chk4.Value != null ? true : (bool)chk4.Value.Equals(false));
                    chk5.Value = !(chk5.Value != null ? true : (bool)chk5.Value.Equals(false));
                    chk6.Value = !(chk6.Value != null ? true : (bool)chk6.Value.Equals(false));
                }
            }
            catch (Exception)
            {
            }
        }

        private void Frm_Priv_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
