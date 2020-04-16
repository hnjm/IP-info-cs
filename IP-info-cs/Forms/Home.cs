using System;
using System.Drawing;
using System.Windows.Forms;

namespace IP_info_cs.Forms
{
    public partial class Home : Form
    {
        protected CheckBox[] chckbox_list;
        private enum WhichAPICheckBox { Astro, Geo, Timezone }
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
        private static void BuildAstro() { }
        private static void BuildGeo() { }
        private static void BuildTimezone() { }
        #endregion
        #region Helper
        private WhichAPICheckBox GetSelectedCheckbox()
        {
            var whichone = WhichAPICheckBox.Astro;
            foreach (var chckbox in chckbox_list)
                if (chckbox.Checked)
                {
                    if (chckbox == chckboxAstro)
                        whichone = WhichAPICheckBox.Astro;
                    if (chckbox == chckboxGeo)
                        whichone = WhichAPICheckBox.Geo;
                    if (chckbox == chckboxTimezone)
                        whichone = WhichAPICheckBox.Timezone;
                }
            return whichone;
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
            switch (GetSelectedCheckbox())
            {
                case WhichAPICheckBox.Astro:
                    BuildAstro();
                    break;
                case WhichAPICheckBox.Geo:
                    BuildGeo();
                    break;
                case WhichAPICheckBox.Timezone:
                    BuildTimezone();
                    break;
            }
        }
    }
}
