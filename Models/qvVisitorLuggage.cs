using qvisitorCorp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvVisitorLuggage")]
    public class qvVisitorLuggage
    {
        public int Id { get; set; }
        public string Luggage { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual qvOrder Order { get; set; }

        public int VisitorId { get; set; }
        [ForeignKey ("VisitorId")]
        public virtual qvVisitor Visitor { get; set; }
    }
}
