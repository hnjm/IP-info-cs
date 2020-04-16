using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;


namespace IP_Info.API
{
    public class Time_zone : IAPI
    {
        private struct ResultObj
        {
            public const string geo = "geo";
        }
        private void ResMgr()
        {
            if (base.Continue)
                foreach (var res in base.Res)
                    if (res.Value.Type == JTokenType.Object)
                    {
                        switch (res.Key)
                        {
                            case ResultObj.geo:
                                this.res_geo = JsonConvert.DeserializeObject(res.Value.ToString())
                                    as JObject;
                                break;
                            default:
                                break;
                        }
                    }
        }
        public JObject res_geo = new JObject();

        /// <summary>
        /// Request with devices IP Address. 
        /// result can be accessed by Res ResLoc field.
        /// </summary>
        public Time_zone() : base(Data.TIMEZONE_URL) => this.ResMgr();
        /// <summary>
        /// Request with the given IP Address.
        /// result can be accessed by Res and ResLoc field.
        /// </summary>
        /// <param name="IPaddress"></param>
        public Time_zone(string IPaddress = null) : base(Data.TIMEZONE_URL, IPaddress) => this.ResMgr();
    }
}
