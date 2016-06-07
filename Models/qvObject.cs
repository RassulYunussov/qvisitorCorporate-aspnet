using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvObject")]
    public class qvObject
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        [Column("cityid")]
        public int CityId { get; set; }
        public qvCity City { get; set; }
        public ICollection<qvCheckPoint> CheckPoints { get; set; }

        public qvObject() { }
    }
}
