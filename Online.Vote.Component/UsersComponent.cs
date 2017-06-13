using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Criterion;
using Castle.Services.Transaction;
using Castle.ActiveRecord.Queries;
using Online.Vote.Domain;
using Online.Vote.Manager;
using Online.Vote.Server;

namespace Online.Vote.Component
{
    public class UserComponent : BaseComponent<Users, UsersManager>, IUsersService
    {
    
    }
}
