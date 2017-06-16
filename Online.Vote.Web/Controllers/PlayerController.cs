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

        [HttpPost]
        public int  AddScore(int screenPlayerID, bool suportFirst, bool suportSecond)
        {
            MatchPKInfo mpi = Container.Instance.Resolve<IMatchPKInfoService>().Get(screenPlayerID);
            var list = Container.Instance.Resolve<IMatchPKInfoService>().Get(screenPlayerID);
            if (list != null)
            {
                if (suportFirst == true)
                {
                    list.FirstPlayerScore++;
                }
                if (suportSecond == true)
                {
                    list.SecondPlayerScore++;
                }

            }
            else
            {
                return 0;
            }
            try
            {
                Container.Instance.Resolve<IMatchPKInfoService>().Update(list);
            }
            catch (Exception)
            {

                return 0;
            }

            return 1;
           
        }
   
    }
}