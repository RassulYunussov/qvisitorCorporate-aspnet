using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvCheckPoint")]
    public class qvCheckPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ObjectId { get; set; }
        [ForeignKey("ObjectId")]
        public virtual qvObject Object { get; set; }

        public virtual ICollection<qvEntrance> Entrance { get; set; }
        public virtual ICollection<qvNotRecognizedDoc> NotRecognizedDoc { get; set; }
    }
}
