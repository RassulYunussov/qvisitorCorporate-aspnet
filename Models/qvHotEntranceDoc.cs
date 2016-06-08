using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvHotEntranceDoc")]
    public class qvHotEntranceDoc
    {
        public int Id { get; set; }
        public byte [] Document { get; set; }

        public int HotEntranceId { get; set; }
        [ForeignKey ("HotEntranceId")]
        public qvHotEntrance HotEntrance { get; set; }
    }
}
