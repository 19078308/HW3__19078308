using EF01DatabaseFirstSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF01DatabaseFirstSample.Controllers
{
    public class MaintainController : Controller
    {
        // GET: Maintain
        private LibraryEntities _context;
        public MaintainController()
        {
            _context = new LibraryEntities(); // Initialize your DbContext
        }
        public ActionResult Maintain()
        {
            List<authors> authors = _context.authors.ToList();
            List<types> types = _context.types.ToList();
            List<borrows> borrows = _context.borrows.ToList();

            MaintainViewModel viewModel = new MaintainViewModel
            {
                Authors = authors,
                Types = types, 
                Borrows = borrows
            };

            return View("Maintain", viewModel);
        }
    }
}