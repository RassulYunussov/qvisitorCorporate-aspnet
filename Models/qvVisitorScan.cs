using qvisitorCorp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvVisitorScan")]
    public class qvVisitorScan
    {
        public int Id { get; set; }
        public byte[] Scan  { get; set; }

        public int VisitorId { get; set; }
        [ForeignKey("VisitorId")]
        public virtual qvVisitor Visitor { get; set; }

    }
}
