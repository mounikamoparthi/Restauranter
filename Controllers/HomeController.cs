using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using restauranter.Models;

namespace restauranter.Controllers
{
    public class HomeController : Controller
    {
        private RestaurantContext _context;
 
        public HomeController(RestaurantContext context)
        {
            _context = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        [Route("list")]
        public IActionResult List()
        {
            List<Person> AllUsers = _context.user.ToList();
            ViewBag.AllUsers = AllUsers;
            return View("list");
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(Person NewPerson)
        {
            NewPerson.created_at = DateTime.Now;
            NewPerson.updated_at = DateTime.Now;

             _context.Add(NewPerson);
            // OR _context.Users.Add(NewPerson);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
