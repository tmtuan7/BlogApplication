using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Model
{
    public class Image
    {
        public int ImageID { get; set; }
        public string ImageStream { get; set; }

        // ---- Thuộc tính liên quan đến khoá ngoại
        public int PostID { get; set; }
        public Post Post { get; set; }
    }
}
