using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    public class qvObject
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        public qvCity City { get; set; }
        public ICollection<qvCheckPoint> CheckPoints { get; set; }

        public qvObject() { }
    }
}
