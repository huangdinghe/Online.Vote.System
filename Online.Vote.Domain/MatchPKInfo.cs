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
        /// PK实体
        /// </summary
    [ActiveRecord("MatchPKInfo")]
    public class MatchPKInfo : EntityBase
    {
        /// <summary>
        /// MatchId 外键映射 外键映射用BelongTo
        /// </summary>
        [BelongsTo("MatchId")]
        public Match MatchId { get; set; }

        /// <summary>
        /// FirstPlayerId 外键映射
        /// </summary>
        [BelongsTo("PlayerId")]
        public Player FirstPlayerId{ get; set; }

        /// <summary>
        /// SecondPlayerId 外键映射
        /// </summary>
        [BelongsTo("PlayerId")]
        public Player SecondPlayerId { get; set; }

        /// <summary>
        /// FirstSongName
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "FirstSongName")]
        public virtual string FirstSongName { get; set; }

        /// <summary>
        /// SecondSongName
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "SecondSongName")]
        public virtual string SecondSongName { get; set; }



        /// <summary>
        /// 选手照片
        /// </summary>
        [Property(NotNull = true, Length = 200)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(200, ErrorMessage = "不能超过200个字符")]
        [Display(Name = "选手照片")]
        public virtual string PlayerImage { get; set; }

        /// <summary>
        /// 选手1 分数
        /// </summary>
        [Property(NotNull = true)]
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "选手1分数")]
        public virtual decimal FirstPlayerScore { get; set; }

        /// <summary>
        /// 选手2 分数
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "选手2分数")]
        public virtual decimal SecondPlayerScore { get; set; }
        
        /// <summary>
        /// 场次状态
        /// </summary>
        public short MatchFlag { get; set; }

     
    }
}
