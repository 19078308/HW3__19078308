using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF01DatabaseFirstSample.Models
{
    public class MaintainViewModel
    {
        public List<types> Types { get; set; }
        public List<authors> Authors { get; set; }
        public List<borrows> Borrows { get; set; }
    }
}