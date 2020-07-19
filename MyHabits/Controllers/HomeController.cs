using Microsoft.AspNetCore.Mvc;
using MyHabits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHabits.Controllers
{
    public class HomeController :Controller
    {
        private readonly HabitContext _context;
        public HomeController(HabitContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            ViewBag.Users = users;
            ViewBag.Error = TempData["Error"];
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreditReward(string tagid)
        {
            Activity activity = _context.Activities.Where(a => a.Tag == tagid).First();
            User user = _context.Users.Where(u => u.Id == activity.UserId).First();
            user.Reward += activity.Reward;
            _context.Users.Update(user);
            _context.SaveChanges();
            ViewBag.Users = _context.Users.ToList();
            return RedirectToAction("Index");
        }
    }
}
