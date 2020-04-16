using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;


namespace IP_Info.API
{
    public sealed class Astronomy : IAPI
    {
        public JObject res_location = new JObject();
        public void ResMgr()
        {
            if (base.Continue)
                foreach (var res in base.Res)
                    if (res.Value.Type == JTokenType.Object)
                        this.res_location = JsonConvert.DeserializeObject(res.Value.ToString()) as JObject;
        }

        /// <summary>
        /// Request with devices IP Address. 
        /// result can be accessed by Res ResLoc field.
        /// </summary>
        public Astronomy() : base(Data.ASTRO_URL) => ResMgr();
        /// <summary>
        /// Request with the given IP Address.
        /// result can be accessed by Res and ResLoc field.
        /// </summary>
        /// <param name="IPaddress"></param>
        public Astronomy(string IPaddress = null) : base(Data.GEO_URL, IPaddress) => ResMgr();
    }
}
