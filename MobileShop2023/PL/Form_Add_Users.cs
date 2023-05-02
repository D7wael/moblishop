using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop2023.PL
{
    public partial class Form_Add_Users : Form
    {
        public Form_Add_Users()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.frm_Users amn = new Login.frm_Users();
            amn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login.Frm_Priv_user ssr = new Login.Frm_Priv_user();
            ssr.ShowDialog();
        }

        private void Form_Add_Users_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; //  منع الفورم من التكبير بالفارة
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login.frm_Users amn = new Login.frm_Users();
            amn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login.Frm_Priv_user ssr = new Login.Frm_Priv_user();
            ssr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Add_Users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Login.frm_Users1 user1 = new Login.frm_Users1();
            //user1.ShowDialog();
        }
    }
}
