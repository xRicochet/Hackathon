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
    public class ManageController : Controller
    {

        private UnitOfWork unitOfWork = new UnitOfWork();
        private Service<User> userRepository;
        private IUserService userService;

        public ManageController()
        {
            this.userRepository = unitOfWork.Service<User>();
            this.userService = new UserService();
        }
        // GET: Manage
        public ActionResult Index(int Id)
        {
            var user = userService.GetUserById(Id);
            return View(user);
        }
    }
}