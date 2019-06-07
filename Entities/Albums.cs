using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Albums 
    {
        private string id;
        private string userId;
        private string title;

        public string Id { get => id; set => id = value; }
        public string UserId { get => userId; set => userId = value; }
        public string Title { get => title; set => title = value; }

    }
}