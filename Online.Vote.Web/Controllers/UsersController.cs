using Online.Vote.Core;
using Online.Vote.Domain;
using Online.Vote.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online.Vote.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
           IList<Users> users = Container.Instance.Resolve<IUsersService>().GetAll();
            return View(users);
        }
        [HttpGet]
        public ActionResult Login()
        {
            Users users = new Users();

            return View(users);
        }

        [HttpPost]
        public ActionResult Login(Users model)
        {
            IUsersService userService = Container.Instance.Resolve<IUsersService>();
            Domain.Users loginedUser = userService.Login(model.UsersName, model.Password);
            if (loginedUser != null)//当用户名和密码正确时
            {
                //页面跳转到主页面
                return RedirectToAction("Index", "MatchPKInfo");
            }
            else
            {
                //如果登录不成功，则向用户提示错误信息
                ViewBag.ErrorMsg = "用户名或密码错误。";
                return View(model);
            }

        }
    }
}