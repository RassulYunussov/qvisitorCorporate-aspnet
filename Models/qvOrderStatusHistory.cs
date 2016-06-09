using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{ 
    [Table ("qvOrderStatusHistory")]
    public class qvOrderStatusHistory
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public qvOrder Orders { get; set; }

        public int OldStatusId { get; set; }
        public int NewStatusId { get; set; }

        public DateTime ActionDate { get; set; }
    }
}
