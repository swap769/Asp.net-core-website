﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using website.Data;
using website.Models.Account;

namespace website.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list=_context.Users.ToList();   

            return View(list);
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            Console.WriteLine("login");
            if (ModelState.IsValid)
            {
                var user = await _context.Users.Where(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefaultAsync();
                if (user != null)
                {
                    Console.WriteLine("user is logggedIn");
                    return RedirectToAction(controllerName:"Account",actionName:"Index");
                }
                else
                {
                    Console.WriteLine("else");
                    TempData["errorPassword"] = "Invaild Password";
                    return View();
                }
            }
            else
            {
                TempData["errorUserEmail"] = "Email not found";
                return View();
            }
        }
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(Users model)
        {
            var exitUser = await _context.Users.Where(x => x.Email == model.Email).FirstOrDefaultAsync();
            if (exitUser == null)
            {
                if (ModelState.IsValid)
                {
                    var data = new Users()
                    {
                        Id = model.Id,
                        Name = model.Name,
                        Password = model.Password,
                        Email = model.Email,
                        Address = model.Address,
                    };
                    _context.Users.Add(data);
                    _context.SaveChanges();
                    TempData["sucessMessage"] = "Sucessfully Registered";
                    return RedirectToAction("Login");
                }
            }
            else
            {
                TempData["errorMessage"] = "Email already exists";
                return View();
            }
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }

    }
}
