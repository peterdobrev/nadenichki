﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConfigurationWebShopDemo.Models;
using ConfigurationWebShopDemo.Data;

namespace ConfigurationWebShopDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignUpDbContext _db;
        private readonly CompdatabaseDbContext _dbcomp;


        public HomeController(ILogger<HomeController> logger, SignUpDbContext db, CompdatabaseDbContext dbcomp)
        {
            _logger = logger;
            _db = db;
            _dbcomp = dbcomp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogIn(SignUp obj)
        {

            foreach (var item in _db.SignUp)
            {
                if (item.Username == obj.Username && item.Password == obj.Password)
                {
                    Logged.LoggedIn = true;
                    if(obj.UserId <= 4)
                    {
                        Logged.IsAdmin = true;
                    }
                    else
                    {
                        Logged.IsAdmin = false;
                    }

                    foreach (var x in _dbcomp.Product)
                    {
                        _dbcomp.Product.Remove(x);
                    }
                    _dbcomp.SaveChanges();

                    return View("../CategoryProduct/Index");
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(string email)
        {
            SignUp newSignUp = new SignUp();
            newSignUp.Email = email;
            return View(newSignUp);
        }

        public IActionResult ChangePasswordButActually(string email, string password)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Order()
        {
            foreach (var x in _dbcomp.Product)
            {
                _dbcomp.Product.Remove(x);
            }
            _dbcomp.SaveChanges();
            return View();
        }

        public IActionResult LogOut()
        {
            Logged.LoggedIn = false;
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
