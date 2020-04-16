namespace IP_Info.API
{
    struct Data
    {
        public const string API_URL = "https://api.ipgeolocation.io";
        public const string API_KEY = "b6fdf6fca9c141b8b5037216f0ab1dfd";
        public const string ASTRO_URL = API_URL + "/astronomy?";
        public const string GEO_URL = API_URL + "/ipgeo?" + "include=security" + "&";
        public const string TIMEZONE_URL = API_URL + "/timezone?";
    }
}
