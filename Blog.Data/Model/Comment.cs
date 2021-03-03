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
    }
}
