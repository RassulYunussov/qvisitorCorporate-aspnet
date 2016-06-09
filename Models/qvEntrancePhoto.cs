using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvEntrancePhoto")]
    public class qvEntrancePhoto
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }

        public int EntranceId { get; set; }
        [ForeignKey("EntranceId")]
        public qvEntrance Entrance { get; set; }
    }
}

