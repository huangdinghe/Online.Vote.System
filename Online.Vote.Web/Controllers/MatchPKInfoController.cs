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
            IList<MatchPKInfo> matchpkinfos = Container.Instance.Resolve<IMatchPKInfoService>().GetAll();
            return View(matchpkinfos);
        }
    }
}