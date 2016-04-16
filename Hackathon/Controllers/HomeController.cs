using Hackathon.Data;
using Hackathon.DbData;
using Hackathon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hackathon.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Service<User> userRepository;
        public IUserService userService;

        public HomeController()
        {
            this.userRepository = unitOfWork.Service<User>();
            this.userService = new UserService();
        }
        public ActionResult Index()
        {
            var x = new UserService();
            var a = x.GetUserById(1);
            var b = new User();
            b.Email = "bogdan.luncasu@gmail.com";
            b.FirstName = "Bogdan";
            b.LastName = "Luncasu";
            b.Password = "123456";
            var c = userService.GetAllUsers();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}