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

        [Column ("objectid")]
        public int ObjectId { get; set; }
        public qvObject Object { get; set; }
    }
}
