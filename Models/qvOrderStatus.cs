using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvOrderStatus")]
    public class qvOrderStatus
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<qvOrder> Order { get; set; }

        public qvOrderStatus() { }
    }
}
