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
using System.Security.Cryptography; // خاص بتشفير كلمات المرور

namespace MobileShop2023.Login
{
    public partial class Frm_login : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        public Frm_login()
        {
            InitializeComponent();
        }
        internal class UserInformation // لعرض اسم المستخدم الحالي
        {
            public static string CurrentLoggedInUser // لعرض اسم المستخدم الحالي
            {
                get; // لعرض اسم المستخدم الحالي
                set; // لعرض اسم المستخدم الحالي
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
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string psw = SHA512(txt_password.Text);

                SqlCommand cmd = new SqlCommand(" select * from TB_Users where User_name_login=@User_name and Pass_word=@psw ", sqlcon);
                cmd.Parameters.Add(new SqlParameter("@User_name", SqlDbType.VarChar)).Value = txt_Username.Text;
                cmd.Parameters.Add(new SqlParameter("@psw", SqlDbType.VarChar)).Value = psw;

                sqlcon.Open();
                SqlDataReader Ra = cmd.ExecuteReader();
                Ra.Read();
                if (Ra.HasRows)
                {
                    // لا تنسى نسح هذا السطرين بالأخضر إلى الكلاس الموجود أسف الجداول program.cs
                     //  public static string user_ID;
                     //[STAThread]

                    Program.user_ID = Ra[0].ToString();
                    PL.Form_Main mn = new PL.Form_Main();
                    this.Hide();
                    UserInformation.CurrentLoggedInUser = txt_Username.Text.Trim(); // لعرض اسم المستخدم الحالي
                    mn.ShowDialog();
                    // ثم لإغلاق الفورم الحالي
                    this.Close();
                    // MessageBox.Show("Login Ok " + Program.user_ID);
                }
                else
                    MessageBox.Show(" تأكد من اسم المستخدم وكلمة المرور ");
                sqlcon.Close();
                Ra.Close();

                txt_Username.Text = null;
                txt_password.Text = null;
                this.ActiveControl = txt_Username;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)   // الدخول بزر انتر مرة واحدة
            {
                btn_login_Click(sender, e);
            }
        }
        private void Frm_login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // منع الفورم من التكبير بالفارة          
            this.ActiveControl = txt_Username; // القراءة من الصندوق الأول


            btn_login.TabStop = false;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent


            buttonSERVER.TabStop = false;
            buttonSERVER.FlatStyle = FlatStyle.Flat;
            buttonSERVER.FlatAppearance.BorderSize = 0;
            buttonSERVER.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

        }

        private void bun_Connection_Click(object sender, EventArgs e)
        {
            //if(Properties.Settings.Default.CHECKSHOW == true)
            //{
            //    MessageBox.Show("غير مسرح لك بالتعديل على البيانات","تأكيد");
            //}
            //else
            //{
            //    PL.FRM_SERVER SERV = new PL.FRM_SERVER();
            //    SERV.ShowDialog();
            //}
        }

        private void Frm_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void buttonSERVER_Click(object sender, EventArgs e)
        {
            PL.FRM_SERVER SERV = new PL.FRM_SERVER();
            SERV.ShowDialog();
        }
    }
}