using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositorySystem.Core.Entities
{
    public class Item
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
        /// 条码号
        /// </summary>
        public virtual string BarCode { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        public virtual string Model { get; set; }

        /// <summary>
        /// 公司
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// 商品进货价
        /// </summary>
        public virtual double Xprice { get; set; }

        /// <summary>
        /// 批发价
        /// </summary>
        public virtual double WholesalePrice { get; set; }

        /// <summary>
        /// 零售价
        /// </summary>
        public virtual double RetailPrice { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        public virtual int Inventory { get; set; }
        
    }
}
