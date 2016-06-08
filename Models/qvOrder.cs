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

        public int OrderTypeid { get; set; }
        [ForeignKey("OrderTypeid")]
        public virtual qvOrderType OrderType { get; set; }

        public int OrderStausid { get; set; }
        [ForeignKey("OrderStausid")]
        public virtual qvOrderStatus OrderStatus { get; set;}

        public DateTime Sdate { get; set; }
        public DateTime Edate { get; set; }
        public DateTime Opentime { get; set; }
        public DateTime Closetime { get; set; }

        public virtual ICollection <qvVisitorLuggage> VisitorLuggage { get; set; }
        
        public qvOrder() { }

    }
}
