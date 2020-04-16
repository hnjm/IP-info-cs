using System;
using System.Drawing;
using System.Windows.Forms;

namespace IP_info_cs.Forms
{
    public partial class Home : Form
    {
        protected CheckBox[] chckbox_list;

        public Home()
        {
            InitializeComponent();
            this.chckbox_list = new CheckBox[3]
            {
                this.chckboxGeo,
                this.chckboxAstro,
                this.chckboxTimezone,
            };
        }

        private void chckboxTimezone_Click(object sender, EventArgs e)
        {
            iTool.Winform.iCheckbox.Uniquify(ref this.chckbox_list, ref this.chckboxTimezone);
        }

        private void chckboxGeo_Click(object sender, EventArgs e)
        {
            iTool.Winform.iCheckbox.Uniquify(ref this.chckbox_list, ref this.chckboxGeo);
        }

        private void chckboxAstro_Click(object sender, EventArgs e)
        {
            iTool.Winform.iCheckbox.Uniquify(ref this.chckbox_list, ref this.chckboxAstro);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
