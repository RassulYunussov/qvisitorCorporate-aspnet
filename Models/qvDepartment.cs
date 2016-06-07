using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    public class qvDepartment
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public qvBranch Branch { get; set; }
        public ICollection<qvHotEntrance> HotEntrances { get; set; }

        public qvDepartment() { }
}
}
