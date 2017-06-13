﻿using Castle.ActiveRecord;
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
        /// MatchId
        /// </summary>
        [Property("MatchId")]
        public virtual int MatchId { get; set; }

        /// <summary>
        /// FirstPlayerId
        /// </summary>
        [Property("FirstPlayerID")]
        public virtual int FirstPlayerId{ get; set; }

        /// <summary>
        /// SecondPlayerId
        /// </summary>
        [Property("SecondPlayerId")]
        public virtual int SecondPlayerId { get; set; }

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
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "选手照片")]
        public virtual string PlayerImage { get; set; }

        /// <summary>
        /// 选手1 分数
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
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
        public short Flag { get; set; }


    }
}