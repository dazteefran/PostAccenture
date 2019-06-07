using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Service
{
    public class UserService
    {
        public User GetUsers()
        {
            RESTClient rClient = new RESTClient();

            rClient.endPoint = string.Format("http://jsonplaceholder.typicode.com/users/{0}", 1);
            return JsonConvert.DeserializeObject<User>(rClient.makeRequest());
        }
    }
}
