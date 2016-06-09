using qvisitorCorp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvEntrance")]
    public class qvEntrance
    {
        public int Id { get; set; }

        public int CheckPointId { get; set; }
        [ForeignKey("CheckPointId")]
        public qvCheckPoint CheckPoint { get; set; }

        public DateTime ActionDate { get; set; }

        public int EntranceTypeId { get; set; }
        [ForeignKey("EntranceTypeId")]
        public qvEntranceType EntranceType { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public qvOrder Order { get; set; }

        public int VisitorId { get; set; }
        [ForeignKey("VisitorId")]
        public qvVisitor Visitor { get; set; }

        public ICollection<qvEntrancePhoto> EntrancePhoto { get; set; }
        public ICollection<qvEntranceDoc> EntranceDoc { get; set; }

    }
}
