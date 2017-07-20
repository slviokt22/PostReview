using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostReview.Models
{
    public class Like
    {
        public string email { get; set; }
        public string postid { get; set; }
        public ApplicationUser user { get; set; }
        public Post post { get; set; }
        public Boolean status { get; set; }
    }
}