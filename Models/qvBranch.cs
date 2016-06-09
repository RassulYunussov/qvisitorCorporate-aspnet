using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace qvisitorCorp.Models
{
    [Table ("qvBranch")]
    public class qvBranch
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public qvCity City { get; set; }

        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual qvCompany Company { get; set; }

        public int HighBranchId { get; set; }
        [ForeignKey("HighBranchId")]
        public virtual qvBranch HighBranch { get; set; }

        public virtual ICollection <qvBranch> LowBranches { get; set; }
        public virtual ICollection <qvDepartment> Departments { get; set; }
    }
}
