using Online.Vote.Domain;
using Online.Vote.Manager;
using Online.Vote.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Online.Vote.Component
{
  public  class MatchComponent : BaseComponent<Match, MatchManager>, IMatchService
    {
    }
}
