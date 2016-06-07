using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    public class qvCheckPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public qvObject Object { get; set; }
    }
}
