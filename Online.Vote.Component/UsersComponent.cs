using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Criterion;
using Castle.Services.Transaction;
using Castle.ActiveRecord.Queries;
using Online.Vote.Domain;
using Online.Vote.Manager;
using Online.Vote.Service;

namespace Online.Vote.Component
{
    public class UsersComponent : BaseComponent<Users, UsersManager>, IUsersService
    {
    
    }
}
