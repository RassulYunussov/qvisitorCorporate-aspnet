using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvEntranceDoc")]
    public class qvEntranceDoc
    {
        public int Id { get; set; }
        public byte[] Scan { get; set; }

        public int EntranceId { get; set; }
        [ForeignKey("EntranceId")]
        public qvEntrance Entrance { get; set; }
    }
}
