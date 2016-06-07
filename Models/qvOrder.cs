using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    public class qvOrder
    {
        public int Id { get; set; }
        public qvOrderType OrderType { get; set; }
        public qvOrderStatus OrderStatus { get; set;}
        public DateTime Sdate { get; set; }
        public DateTime Edate { get; set; }
        public DateTime Opentime { get; set; }
        public DateTime Closetime { get; set; }

        public qvOrder() { }

    }
}
