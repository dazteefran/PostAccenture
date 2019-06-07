using Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class PostFacade
    {
        public Posts GetPosts()
        {
            return new PostService().GetPosts();
        }
    }
}
