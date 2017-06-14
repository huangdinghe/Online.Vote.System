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
            //查询为开启状态的PK表
            IList<MatchPKInfo> matchpkinfos = Container.Instance.Resolve<IMatchPKInfoService>().GetAll().Where(m => m.MatchFlag == 1).ToList();
            return View(matchpkinfos);

            
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MatchPKInfo matchinfo)
        {
            Container.Instance.Resolve<IMatchPKInfoService>().Create(matchinfo);
            return View(matchinfo);
        }
    }
}