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
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            IList<Player> players = Container.Instance.Resolve<IPlayerService>().GetAll();
            return View(players);
        }
        public ActionResult AddScore()
        {
            return View();
        }
    }
}