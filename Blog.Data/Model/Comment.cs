using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Model
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }

        // ---- Thuộc tính liên quan đến khoá ngoại
        public int UserID { get; set; }
        public User User { get; set; }

        public int PostID { get; set; }
        public Post Post { get; set; }
    }
}
