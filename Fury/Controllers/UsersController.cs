using Fury.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Fury.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext _Context;
        public UsersController()
        {
            _Context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult NewUser()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(User  U)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new User
                {
                    ID = U.ID,
                    Name = U.Name,
                    Password = U.Password

                
                };
                return View("NewUser",viewModel);
            }
            var id = U.ID;
            var name = U.Name;
            var pass = U.Password;
            _Context.user.Add(U);
            _Context.SaveChanges();

           

            return RedirectToAction("NewUser");
        }
        [Authorize]
        public ActionResult NewTechnican()
        {

            return View();
        }
        
        [HttpPost]
        public ActionResult CreateTech(Technician T)
        {
            var id = T.ID;
            var name = T.Name;
            var pass = T.Password;
            _Context.technician.Add(T);
            _Context.SaveChanges();



            return RedirectToAction("NewTechnican");
        }
        
    }
}