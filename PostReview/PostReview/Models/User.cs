using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostReview.Models
{
    public class User
    {
        //public User()
        //{
        //    this.Post = new HashSet<Post>();
        //}
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        //public virtual ICollection<Post> Post { get; set; }
    }
}