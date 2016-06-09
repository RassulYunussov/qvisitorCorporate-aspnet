using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvNotRecognizedDoc")]
    public class qvNotRecognizedDoc
    {
        public int Id { get; set; }
        public byte[] Scan{ get; set; }

        public int CheckPointId { get; set; }
        [ForeignKey("CheckPointId")]
        public qvCheckPoint CheckPoint { get; set; }
    }
}
