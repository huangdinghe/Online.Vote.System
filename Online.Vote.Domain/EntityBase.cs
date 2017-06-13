using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using System.ComponentModel.DataAnnotations;

namespace Online.Vote.Domain
{
    public class EntityBase
    {
        /// <summary>
        /// 公共的ID
        /// </summary>
        [PrimaryKey(PrimaryKeyType.Identity)]
        [Display(AutoGenerateField = false)]
        public virtual int ID { get; set; }

    }
}
