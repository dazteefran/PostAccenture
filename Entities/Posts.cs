using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Comment
    {
        private string postId;
        private string id;
        private string name;
        private string email;
        private string body;

        public string PostId { get => postId; set => postId = value; }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Body { get => body; set => body = value; }
    }
}