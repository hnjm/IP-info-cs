using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;

// &include=security
namespace IP_Info.API
{
    public class Geolocation : IAPI
    {
        private struct ResultObj
        {
            public const string currency = "currency";
            public const string security = "security";
            public const string time_zone = "time_zone";
        }
        private void ResMgr()
        {
            if (base.Continue)
                foreach (var res in base.Res)
                    if (res.Value.Type == JTokenType.Object)
                    {
                        switch (res.Key)
                        {
                            case ResultObj.currency:
                                this.res_currency = JsonConvert.DeserializeObject(res.Value.ToString())
                                    as JObject;
                                break;
                            case ResultObj.time_zone:
                                this.res_time_zone = JsonConvert.DeserializeObject(res.Value.ToString())
                                    as JObject;
                                break;
                            case ResultObj.security:
                                this.res_security = JsonConvert.DeserializeObject(res.Value.ToString())
                                    as JObject;
                                break;
                            default:
                                break;
                        }
                    }
        }
        public JObject res_currency = new JObject();
        public JObject res_security = new JObject();
        public JObject res_time_zone = new JObject();

        /// <summary>
        /// Request with devices IP Address. 
        /// result can be accessed by Res ResLoc field.
        /// </summary>
        public Geolocation() : base(Data.GEO_URL) => this.ResMgr();
        /// <summary>
        /// Request with the given IP Address.
        /// result can be accessed by Res and ResLoc field.
        /// </summary>
        /// <param name="IPaddress"></param>
        public Geolocation(string IPaddress = null) : base(Data.GEO_URL, IPaddress) => this.ResMgr();
    }

}
