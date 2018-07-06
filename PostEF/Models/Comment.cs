using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PostEF.Models
{
    public class Comment
    {
        [Key]
        public int IdCo { get; set; }

        public string NameComent { get; set; }

        public string TextComent { get; set; }

        public DateTime DateComent { get; set; }

    }
}