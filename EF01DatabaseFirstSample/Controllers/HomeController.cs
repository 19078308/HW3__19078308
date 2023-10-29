using EF01DatabaseFirstSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Web.UI;

namespace EF01DatabaseFirstSample.Controllers
{
    public class HomeController : Controller
    {
        //private readonly LibraryEntities libraryEntities;
        // GET: Home
        private LibraryEntities _context;

        public HomeController()
        {
            _context = new LibraryEntities();
        }
        public ActionResult Home()
        {
            //int pageSize = 5;
            //int pageNumber = (Page ?? 1);
            // Retrieve data for Students and Books from your database
            List<students> students = _context.students.ToList();
            List<books> books = _context.books.ToList();

            HomeViewModel viewModel = new HomeViewModel
            {
                Students = students,
                Books = books
            };
            //IPagedList<students> pagedStudents = students.ToPagedList(pageNumber, pageSize);


            return View("Home", viewModel);
        }
    }
}