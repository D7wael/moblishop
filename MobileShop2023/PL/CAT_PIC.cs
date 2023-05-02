using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace MobileShop2023.PL
{
    public partial class CAT_PIC : Form
    {
        public CAT_PIC()
        {
            InitializeComponent();
        }

        private void CAT_PIC_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // منع تكبير الفورم
        }
    }
}
