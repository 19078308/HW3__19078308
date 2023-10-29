using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF01DatabaseFirstSample.Models
{
    public class HomeViewModel
    {
        public List<students> Students { get; set; }
        public List<books> Books { get; set; }
    }
}