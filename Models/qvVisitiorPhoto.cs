using qvisitorCorp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvVisitorPhoto")]
    public class qvVisitiorPhoto
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public DateTime PhotoDate { get; set; }

        public int VisitorId { get; set; }
        [ForeignKey ("VisitorId")]
        public qvVisitor Visitor { get; set; }

        public qvVisitiorPhoto() { }
    }
}
