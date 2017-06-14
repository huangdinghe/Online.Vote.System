using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Vote.Domain
{
    /// <summary>
    /// 用户实体
    /// </summary
    [ActiveRecord("Users")]
    public  class Users : EntityBase
    {
      
        /// <summary>
        /// 用户名
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "用户名")]
        public virtual string UsersName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Display(Name = "密码")]
        public virtual string Password { get; set; }
        public virtual short UsersType { get; set; }

    }
}
