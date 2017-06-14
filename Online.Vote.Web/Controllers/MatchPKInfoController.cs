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
    public class MatchPKInfoController : Controller
    {
        // GET: MatchPKInfo
        public ActionResult Index()
        {          
            //获取场次信息
            ViewBag.match = Container.Instance.Resolve<IMatchService>().GetAll();
            //获取选手信息
            ViewBag.player = Container.Instance.Resolve<IPlayerService>().GetAll();
            
            return View();


        }
       
    }
}