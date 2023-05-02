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

namespace MobileShop2023.PL
{
    public partial class ButtonsNames : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");
        DataTable dt = new DataTable();
     
        SqlDataAdapter Da; // من أجل الصلاحيات
        DataTable Dt = new DataTable();

        BL.ALLPrograms log = new BL.ALLPrograms();
        public ButtonsNames()
        {
            InitializeComponent();

            LoadPriv();// تحميل الصلاحيات 
        }
        void LoadPriv()
        {
            try
            {

                Da = new SqlDataAdapter("select Priv_Add , Priv_Edit , Priv_Delete , Priv_Open FROM TB_Priv where  Priv_Screen_ID =1 and Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + "", sqlcon);
                Da.Fill(Dt);

                if (Dt.Rows[0][0].ToString() == "False" || Dt.Rows[0][0].ToString() == string.Empty)
                    btn_SAVE.Enabled = false;

                if (Dt.Rows[0][1].ToString() == "False" || Dt.Rows[0][1].ToString() == string.Empty)
                    btn_UPDATE.Enabled = false;

                if (Dt.Rows[0][2].ToString() == "False" || Dt.Rows[0][2].ToString() == string.Empty)
                    btn_DELET.Enabled = false;

                if (Dt.Rows[0][3].ToString() == "False" || Dt.Rows[0][3].ToString() == string.Empty)
                    btn_SHOW.Enabled = false;

            }
            catch (Exception)
            {
            }
        }
        private void ButtonsNames_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
    }
}
