using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_info_cs.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent(); 
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            this.btnSubmit.ForeColor = Color.DimGray;
            this.btnSubmit.BackColor = Color.LightGray;
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            this.btnSubmit.ForeColor = Color.GhostWhite;
            this.btnSubmit.BackColor = Color.DimGray;
        }
    }
}
