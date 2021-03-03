using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Model
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public int TotalView { get; set; }

        // ---- Thuộc tính liên quan đến khoá ngoại
        public int UserID { get; set; }
        public User User { get; set; }

        public List<Image> Images { get; set; }

        public List<Comment> Comments { get; set; }

    }
}
