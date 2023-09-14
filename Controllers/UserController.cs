using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
            new User(){UserId = 1,UserName="Sam",UserPwd="sam@123",UserEmail="sam@gmail.com"},
            new User(){UserId = 2,UserName="Ram",UserPwd="ram@123",UserEmail="ram@gmail.com"},
            new User(){UserId = 3,UserName="Rahul",UserPwd="rahul@123",UserEmail="rahul@gmail.com"},
            new User(){UserId = 4,UserName="Kumar",UserPwd="kumar@123",UserEmail="kumar@gmail.com"},
            new User(){UserId = 5,UserName="anisha",UserPwd="anisha@123",UserEmail="anisha@gmail.com"},
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
