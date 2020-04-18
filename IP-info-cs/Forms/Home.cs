using IP_Info.API;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IP_info.Forms
{
    public partial class Home : Form
    {
        private Astronomy astro;
        private Geolocation geo;
        private Time_zone timezone;
        protected CheckBox[] chckbox_list;
        private WhichAPICheckBox whichAPI;
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
        #endregion
        #region Show info
        // If doesn't work, get arg with ref
        private void BuildContent(string header, StringBuilder txt, JObject results)
        {
            txt.AppendLine($"\t < {iTool.iString.ToUpper(header, 0)} info >");
            foreach (var res in results)
                txt.AppendFormat("{0}: {1}", res.Key, res.Value);
        }
        private void ShowGeo() { }
        private void ShowAstro()
        {
            var txt = new StringBuilder();
            BuildContent("basic", txt, this.astro.res_default);
            BuildContent("location", txt, this.astro.res_location);
            this.rtxtboxDisplayInfo.Text = txt.ToString();
        }
        private void ShowTimezone()
        {
            var txt = new StringBuilder();
            BuildContent("basic", txt, this.timezone.res_default);
            BuildContent("geographical", txt, this.timezone.res_geo);
        }
        #endregion
        #region Helper
        private void GetSelectedCheckbox()
        {
            foreach (var chckbox in chckbox_list)
                if (chckbox.Checked)
                {
                    if (chckbox == chckboxAstro)
                        whichAPI = WhichAPICheckBox.Astro;
                    if (chckbox == chckboxGeo)
                        whichAPI = WhichAPICheckBox.Geo;
                    if (chckbox == chckboxTimezone)
                        whichAPI = WhichAPICheckBox.Timezone;
                }
        }
        private void BuildAPI()
        {
            GetSelectedCheckbox();
            switch (this.whichAPI)
            {
                case WhichAPICheckBox.Astro:
                    BuildAstro();
                    ShowAstro();
                    break;
                case WhichAPICheckBox.Geo:
                    BuildGeo();
                    ShowGeo();
                    break;
                case WhichAPICheckBox.Timezone:
                    BuildTimezone();
                    ShowTimezone();
                    break;
            }
        }
        private void BuildAstro() => this.astro = new Astronomy();
        private void BuildGeo() => this.geo = new Geolocation();
        private void BuildTimezone() => this.timezone = new Time_zone();
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
            this.btnSubmit.Enabled = false;
            BuildAPI();
        }
    }
}
