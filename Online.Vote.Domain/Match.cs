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
    /// 场次实体
    /// </summary
    [ActiveRecord("Match")]
    public class Match : EntityBase
    {
        /// <summary>
        /// 场次名
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "场次名")]
        public virtual string MatchName { get; set; }

        /// <summary>
        /// 场次number
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Display(Name = "选手Number")]
        public virtual string MatchNo { get; set; }

        /// <summary>
        /// 场次地址
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "场次地址")]
        public virtual string MatchAddress { get; set; }

        /// <summary>
        /// 场次时间
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "场次时间")]
        public virtual DateTime MatchTime { get; set; }

        /// <summary>
        /// 评委
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "评委")]
        public virtual string Judges { get; set; }

        /// <summary>
        /// 主持人
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "主持人")]
        public virtual string Hostess { get; set; }

        

    }
}
