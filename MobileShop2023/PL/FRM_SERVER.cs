using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobileShop2023.PL
{
    public partial class FRM_SERVER : Form
    {
        public FRM_SERVER()
        {
            InitializeComponent();
        }

        private void FRM_SERVER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FRM_SERVER_Load(object sender, EventArgs e)
        {
            TextServerName.Text = Properties.Settings.Default.SERVERNAME;
            TextDataBase.Text = Properties.Settings.Default.DATABASENAME;
            TextUserName.Text = Properties.Settings.Default.DATABASESUSERNAME;
            TextPassword.Text = Properties.Settings.Default.DATABASEPASSWORD;
          
            if(Properties.Settings.Default.CHECKSHOW == false)
            {
                checkBoxDontShow.Checked = false;
            }

            else
            {
                checkBoxDontShow.Checked = true;
            }
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SERVERNAME = TextServerName.Text;
            Properties.Settings.Default.DATABASENAME = TextDataBase.Text;
            Properties.Settings.Default.DATABASESUSERNAME = TextUserName.Text;
            Properties.Settings.Default.DATABASEPASSWORD = TextPassword.Text;

            if (checkBoxDontShow.Checked == false)
            {
                Properties.Settings.Default.CHECKSHOW = false;
            }

            else
            {
                Properties.Settings.Default.CHECKSHOW = true;
            }

            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ إعدادات السيرفر بنجاح - سيتم إغلاق النظام, يرجى إعادة تشغل البرنامج ", "", MessageBoxButtons.OK);
            Application.Exit();
        }
    }
}
