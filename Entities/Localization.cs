using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Localization
    {
        private string lat;
        private string lng;

        public string Lat { get => lat; set => lat = value; }
        public string Lng { get => lng; set => lng = value; }
    }
}