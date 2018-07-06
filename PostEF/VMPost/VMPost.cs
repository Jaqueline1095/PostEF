using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PostEF.Models;

namespace PostEF.VMPost
{
    public class VMPost
    {
        public Post Post { get; set; }
        public List<Category> Categories { get; private set; }
    }
}