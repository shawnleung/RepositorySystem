using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositorySystem.Core.Entities
{
    public class Company
    {
        /// <summary>
        /// ID
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Cellphone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string QQ { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Website { get; set; }
    }
}
