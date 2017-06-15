using NHibernate.Criterion;
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
    public class PkController : Controller
    {
        // GET: Pk
        public JsonResult GetPkInfo()
        {
            MatchPKInfo mPlayer = null;

            IList<ICriterion> queryConditions = new List<ICriterion>();
            queryConditions.Add(Expression.Eq("MatchFlag", 1));

            IList<MatchPKInfo> list = Container.Instance.Resolve<IMatchPKInfoService>().Find(queryConditions);
            if (list != null) mPlayer = list[0];

            return Json(new
            {
                FirstPlayersName = mPlayer.FirstPlayerId.PlayerName,
                SecondPlayersName = mPlayer.SecondPlayerId.PlayerName,
                FirstPlayersScore = mPlayer.FirstPlayerScore,
                SecondPlayersScore = mPlayer.SecondPlayerScore,
                FirstPlayersImg = mPlayer.FirstPlayerId.PlayerImage,
                SecondPlayersImg = mPlayer.SecondPlayerId.PlayerImage
            }, JsonRequestBehavior.AllowGet);
        }

    }
}