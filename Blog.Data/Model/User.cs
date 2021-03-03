using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastChangePW { get; set; }

        // ---- Thuộc tính liên quan đến khoá ngoại
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
