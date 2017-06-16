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
            //获取pk场次表
          IList<MatchPKInfo> matchpkinfo= Container.Instance.Resolve<IMatchPKInfoService>().GetAll();

            return View(matchpkinfo);
        }

        public ActionResult Create(string matchId,string player1Id,string player2Id,string firstplayersong, string secondplayersong)
        {
            MatchPKInfo match = new MatchPKInfo();
            //实体操作
            match.MatchId = new Match() { ID = int.Parse(matchId) };
            match.FirstPlayerId= new Player() { ID = int.Parse(player1Id) };
            match.SecondPlayerId = new Player() { ID = int.Parse(player2Id) };
            match.FirstPlayerScore = 0;
            match.SecondPlayerScore = 0;
            match.FirstSongName = firstplayersong;
            match.SecondSongName = secondplayersong;
            match.MatchFlag = 1;

            // 调用方法执行保存操作
            Container.Instance.Resolve<IMatchPKInfoService>().Create(match);

            //查询所有以及分配好的数据
            IList<MatchPKInfo> list = Container.Instance.Resolve<IMatchPKInfoService>().GetAll();

            return Json(list, JsonRequestBehavior.AllowGet);
        }


        public JsonResult SetStatus(short flag)
        {
            //查询所有以及分配好的数据
            var conmp = Container.Instance.Resolve<IMatchPKInfoService>();
            IList<MatchPKInfo> list = conmp.GetAll();
            foreach (var item in list)
            {
                if (item.MatchFlag == 0) continue;
                if (item.MatchFlag == 1 && item.MatchFlag < flag) continue;
                item.MatchFlag = flag;

                conmp.Update(item);
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }



    }
}