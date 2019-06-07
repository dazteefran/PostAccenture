using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Service
{
    public class AlbumService
    {
        public Albums GetAlbums()
        {
            RESTClient rClient = new RESTClient();

            rClient.endPoint = string.Format("http://jsonplaceholder.typicode.com/albums/{0}", 1);
            return JsonConvert.DeserializeObject<Albums>(rClient.makeRequest());
        }
    }
}
