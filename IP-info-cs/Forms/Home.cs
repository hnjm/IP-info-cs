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
            this.chckboxAstro.Checked = true;
        }

        #region Static

        #endregion
        #region Helper
        private CheckBox GetSelectedCheckbox()
        {
            CheckBox theone = null;
            foreach (var chckbox in chckbox_list)
                if (chckbox.Checked)
                    theone = chckbox;
            return theone;
        }
        #endregion

        private void chckboxGeo_Click(object sender, EventArgs e)
        {
            iTool.Winform.iCheckbox.Uniquify(ref this.chckbox_list, ref this.chckboxGeo);
        }
        private void chckboxAstro_Click(object sender, EventArgs e)
        {
            iTool.Winform.iCheckbox.Uniquify(ref this.chckbox_list, ref this.chckboxAstro);
        }
        private void chckboxTimezone_Click(object sender, EventArgs e)
        {
            iTool.Winform.iCheckbox.Uniquify(ref this.chckbox_list, ref this.chckboxTimezone);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected: " + GetSelectedCheckbox().Name);
        }
    }
}
