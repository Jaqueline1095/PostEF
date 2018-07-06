using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PostEF.Models
{
    public class Category
    {
        [Key]
        public int IdC { get; set; }

        public string NameCa { get; set; }

        
    }
}