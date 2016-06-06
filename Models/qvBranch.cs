using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    public class qvBranch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public qvCity City { get; set; }
        public qvCompany Company { get; set; }
        public qvBranch HighBranch { get; set; }
        public ICollection <qvBranch> LowBranches { get; set; }
        public ICollection <qvDepartment> Departments { get; set; }
    }
}
