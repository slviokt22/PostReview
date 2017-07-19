using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostReview.Models
{
    public class Like
    {
        public int id { get; set; }
        public int id_user { get; set; }
        public int id_favorit { get; set; }

        public Boolean status { get; set; }
    }
}