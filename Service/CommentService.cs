using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Service
{
    public class CommentService
    {
        public Comment GetComments()
        {
            RESTClient rClient = new RESTClient();

            rClient.endPoint = string.Format("http://jsonplaceholder.typicode.com/comments/{0}", 1);
            return JsonConvert.DeserializeObject<Comment>(rClient.makeRequest());
        }
    }
}
