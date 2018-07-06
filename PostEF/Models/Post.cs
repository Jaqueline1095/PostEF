using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PostEF.Models
{
    public class Post
    {
        [Key]
        public int IdP { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

       
        public DateTime Date { get; set; }

        public int IdC { get; set; }
    
    }
}