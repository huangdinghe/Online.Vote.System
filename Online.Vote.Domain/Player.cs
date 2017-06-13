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
    /// 选手实体
    /// </summary
    [ActiveRecord("Player")]
    public  class Player : EntityBase
    {
        /// <summary>
        /// 选手名
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "选手名")]
        public virtual string PlayerName { get; set; }

        /// <summary>
        /// 选手number
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Display(Name = "选手Number")]
        public virtual string PlayerNo { get; set; }

        /// <summary>
        /// 选手照片
        /// </summary>
        [Property(NotNull = true, Length = 200)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(200, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "选手照片")]
        public virtual string PlayerImage { get; set; }

    }
}
