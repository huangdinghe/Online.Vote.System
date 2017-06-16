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
        public Users Login(string usersname, string password)
        {
            //组织查询条件(标准条件查询)
            IList<NHibernate.Criterion.ICriterion> criterionList = new List<ICriterion>();
            //向条件集合添加查询条件，每个条件之间默认为And关系，从数据库中查询同时满足3个条件的用户信息
            criterionList.Add(Expression.Eq("UsersName", usersname));
            criterionList.Add(Expression.Eq("Password", password));
            criterionList.Add(Expression.Eq("IsActive", true));

            //调用数据访问层的方法执行操作            
            Users user = manager.Get(criterionList);
            return user;
        }
    }
}
