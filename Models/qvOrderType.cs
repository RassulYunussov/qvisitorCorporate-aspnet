using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    public class qvOrderType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public ICollection<qvOrder> Order { get; set; }

        public qvOrderType() { }
    }
}
