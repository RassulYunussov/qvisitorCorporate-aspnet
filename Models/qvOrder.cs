using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvOrder")]
    public class qvOrder
    {
        public int Id { get; set; }

        [Column ("ordertypeid")]
        public int OrderTypeid { get; set; }
        public qvOrderType OrderType { get; set; }
        [Column("orderstatusid")]
        public int OrderStausid { get; set; }
        public qvOrderStatus OrderStatus { get; set;}

        public DateTime Sdate { get; set; }
        public DateTime Edate { get; set; }
        public DateTime Opentime { get; set; }
        public DateTime Closetime { get; set; }

        public qvOrder() { }

    }
}
