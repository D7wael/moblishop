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
// خاص بتشفير كلمات المرور
using System.Security.Cryptography;

namespace MobileShop2023.Login
{
    public partial class frm_Users : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        public frm_Users()
        {
            InitializeComponent();

            LoadData();
            LoadPriv();// تحميل الصلاحيات 
        }

        void LoadData()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select *from TB_Users", sqlcon);
            Da.Fill(Dt);
            try
            {
                listBox1.DataSource = Dt;
                listBox1.DisplayMember = "User_name";
                listBox1.ValueMember = "User_ID";

                txt_User_ID.Text = Dt.Rows[0]["User_ID"].ToString();
                txt_User_Name.Text = Dt.Rows[0]["User_name"].ToString();
                txt_Username_login.Text = Dt.Rows[0][2].ToString();
                txt_Password.Text = Dt.Rows[0][3].ToString();
            }
            catch (Exception)
            {

                // throw;
            }

        }
        void LoadPriv()
        {
            try
            {

                Da = new SqlDataAdapter("select Priv_Add,Priv_Edit,Priv_Delete  from TB_Priv  where  Priv_Screen_ID =1 and Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + "", sqlcon);
                Da.Fill(Dt);

                if (Dt.Rows[0][0].ToString() == "False" || Dt.Rows[0][0].ToString() == string.Empty)
                    btn_NEW.Enabled = false;
                if (Dt.Rows[0][1].ToString() == "False" || Dt.Rows[0][1].ToString() == string.Empty)
                    btn_UPDATE.Enabled = false;
                if (Dt.Rows[0][2].ToString() == "False" || Dt.Rows[0][2].ToString() == string.Empty)
                    btn_DELET.Enabled = false;

            }
            catch (Exception)
            {
            }
        }
        private string SHA512(string Pass_word)
        {

            SHA512Managed SHA512 = new SHA512Managed();
            byte[] Hash = System.Text.Encoding.UTF8.GetBytes(Pass_word);
            Hash = SHA512.ComputeHash(Hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();

        }

        private void frm_Users_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; //  منع الفورم من التكبير بالفارة      
            this.ActiveControl = txt_User_Name; //  القراءة من الصندوق الأول       
        }

        private void btn_NEW_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txt_User_Name;

            txt_User_ID.Clear();
            txt_User_Name.Clear();
            txt_Username_login.Clear();
            txt_Password.Clear();
            txt_Password2.Visible = true;
            lab_PASS2.Visible = true;
            btn_cancel.Visible = true;
            btn_CLOSE.Enabled = false;
            btn_SAVE.Enabled = false;
            btn_DELET.Enabled = false;
            btn_UPDATE.Enabled = false;
            btn_NEW.Enabled = false;

            SqlCommand cmd = new SqlCommand("select ISNULL (MAX (User_ID)+1,1001) from TB_Users", sqlcon);
            sqlcon.Open();
            SqlDataReader Ra = cmd.ExecuteReader();

            Ra.Read();
            txt_User_ID.Text = Ra[0].ToString();
            Ra.Close();
            sqlcon.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_Password2.Visible = false;
            lab_PASS2.Visible = false;
            btn_CLOSE.Enabled = true;
            btn_SAVE.Enabled = false;
            btn_DELET.Enabled = true;
            btn_UPDATE.Enabled = true;
            btn_NEW.Enabled = true;
            btn_cancel.Visible = false;
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            string password = SHA512(txt_Password.Text);
            try
            {
                SqlCommand cmd = new SqlCommand(" insert into TB_Users Values(@User_id,@User_name,@User_login,@Pass_word) " +
                                                 "  insert into TB_Priv (Priv_screen_ID,Priv_User_ID) select Screen_ID,@User_id  from TB_screens", sqlcon);
                cmd.Parameters.Add(new SqlParameter("@User_id", SqlDbType.Int)).Value = txt_User_ID.Text;
                cmd.Parameters.Add(new SqlParameter("@User_name", SqlDbType.VarChar)).Value = txt_User_Name.Text;
                cmd.Parameters.Add(new SqlParameter("@User_login", SqlDbType.VarChar)).Value = txt_Username_login.Text;
                cmd.Parameters.Add(new SqlParameter("@Pass_word", SqlDbType.VarChar)).Value = password;

                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                btn_cancel_Click(sender, e);
                MessageBox.Show("تم الحفظ");
                LoadPriv();
                this.ActiveControl = txt_User_Name;
                btn_SAVE.Enabled = false;

            }
            catch (Exception)
            {

                //throw;
            }    
        }

        private void txt_Password2_Validated(object sender, EventArgs e)
        {
            if (txt_Password2.Text != txt_Password.Text)
            {
                MessageBox.Show(" عذراً كلمةالمرور غير متاطبقة", "خـطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_Password2.Text = null;
                txt_Password.Text = null;
                this.ActiveControl = txt_Password;
                //   txt_Password2.Focus();
                return;
            }
        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            string password = SHA512(txt_Password.Text);

            SqlCommand cmd = new SqlCommand(" update TB_Users  set User_ID= @User_id,  User_name= @User_name, User_name_login=@User_login,Pass_word=@Pass_word where User_ID= " + listBox1.SelectedValue + "", sqlcon);

            cmd.Parameters.Add(new SqlParameter("@User_id", SqlDbType.Int)).Value = txt_User_ID.Text;
            cmd.Parameters.Add(new SqlParameter("@User_name", SqlDbType.VarChar)).Value = txt_User_Name.Text;
            cmd.Parameters.Add(new SqlParameter("@User_login", SqlDbType.VarChar)).Value = txt_Username_login.Text;
            cmd.Parameters.Add(new SqlParameter("@Pass_word", SqlDbType.VarChar)).Value = password;

            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            //btn_can_Click(sender, e);
            MessageBox.Show("تم التعديل");
        }

        private void btn_DELET_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المستخدم", "رسالة ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM TB_Users where User_ID = " + listBox1.SelectedValue + "", sqlcon);
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                btn_cancel_Click(sender, e);
                MessageBox.Show("تم الحذف");
            }
            else
                MessageBox.Show("لم يتم الحذف");
        }

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            int index = listBox1.FindString(txt_search.Text, -1);
            if (index != -1)
                listBox1.SetSelected(index, true);
            else
                MessageBox.Show("القيمة غير موجودة");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter(" select * from TB_Users where User_ID=" + listBox1.SelectedValue + " ", sqlcon);
                Da.Fill(Dt);

                txt_User_ID.Text = Dt.Rows[0]["User_ID"].ToString();
                txt_User_Name.Text = Dt.Rows[0]["User_name"].ToString();
                txt_Username_login.Text = Dt.Rows[0][2].ToString();
                txt_Password.Text = Dt.Rows[0][3].ToString();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void txt_Password2_TextChanged(object sender, EventArgs e)
        {
            btn_SAVE.Enabled = true;
        }

        private void txt_User_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void frm_Users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
