using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostReview.Models
{
    public class Post
    {
        public int id { get; set; }
        public int id_user { get; set; }
        public string tittle { get; set; }
        public string post { get; set; }
        public int replay { get; set; }
        public Boolean status { get; set; }
        public DateTime date { get; set; }

    }
}