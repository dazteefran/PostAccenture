using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Service
{
    public class PostService
    {
        public Posts GetPosts()
        {
            RESTClient rClient = new RESTClient();

            rClient.endPoint = string.Format("http://jsonplaceholder.typicode.com/posts/{0}", 1);
            return JsonConvert.DeserializeObject<Posts>(rClient.makeRequest());
        }
    }
}
