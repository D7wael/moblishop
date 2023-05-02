using System;
using System.Windows.Forms;

namespace MobileShop2023.PL
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         //   label1.Left = label1.Left - 10;
         //   if (label1.Left < 0 - label1.Width)
        //    {
        //        label1.Left = this.Width;
       //     }

            label3.Left = label3.Left - 10;
            if (label3.Left < 0 - label3.Width)
            {
                label3.Left = this.Width;
            }
        }
    }
}
