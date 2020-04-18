using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Collections.Generic;

namespace IP_Info.API
{
    public class IAPI
    {
        protected bool Continue = true;
        protected string url;
        protected dynamic res;
        protected IPAddress IP;
        protected enum IPmodes { self, assigned }  // or i could use IPAssigned as a boolean
        protected JObject Res => this.Continue ? this.res as JObject : null;
        protected void ResDefault()
        {
            if (this.Res == null)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error! No response.", "Error", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error
                    );
                Environment.Exit(0);
            }
            this.res_default = this.Res.DeepClone() as JObject;
            var jTokens = new List<string>();
            foreach (var item in this.res_default)
            {
                if (item.Value.Type == JTokenType.Object)
                    jTokens.Add(item.Key);
            }
            jTokens.ForEach(j => this.res_default.Remove(j));
        }
        public JObject res_default;

        protected void CreateUrl(IPmodes mode, string base_url)
        {
            switch (mode)
            {
                case IPmodes.self:
                    this.url = base_url + "apiKey=" + Data.API_KEY;
                    break;
                case IPmodes.assigned:
                    this.url = base_url + "apiKey=" + Data.API_KEY + "&ip=" + this.IP.ToString();
                    break;
            }
        }
        protected void ValidateIPAddress(string IP)
        {
            try
            {
                this.IP = IPAddress.Parse(IP);
            }
            catch (Exception)
            {
                this.Warn("Invalid IP address!");
                this.Continue = false;
            }
        }
        protected void Warn(string msg)
        {
            System.Windows.Forms.MessageBox.Show(
                       msg,
                       "Error",
                       System.Windows.Forms.MessageBoxButtons.OK,
                       System.Windows.Forms.MessageBoxIcon.Warning
                       );

            this.Continue = false;
        }
        protected void CreateRes()
        {
            try
            {
                res = JsonConvert.DeserializeObject(iTool.Network.iHttp.GetHtml(url));
            }
            catch (Exception _)
            {
                Warn($"Error: {_.Message}");
            }
        }
        //public void Init()
        //{
        //    this.Create(IPmodes.self);
        //}
        //public void Init(string IPaddress = null)
        //{
        //    this.ValidateIPAddress(IPaddress);
        //    this.Create(IPmodes.assigned);
        //}
        public IAPI(string base_url)
        {
            this.CreateUrl(IPmodes.self, base_url);
            this.CreateRes();
            this.ResDefault();
        }
        public IAPI(string base_url, string IPaddress = null)
        {
            this.ValidateIPAddress(IPaddress);
            this.CreateUrl(IPmodes.assigned, base_url);
            this.CreateRes();
            this.ResDefault();
        }
    }
}