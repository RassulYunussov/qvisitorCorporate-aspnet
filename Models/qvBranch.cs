using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvBranch")]
    public class qvBranch
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column("cityid")]
        public int CityId { get; set; }
        public qvCity City { get; set; }

        [Column("companyid")]
        public int CompanyId { get; set; }
        public qvCompany Company { get; set; }

        [Column("highbranchid")]
        public int HighBranchId { get; set; }
        public qvBranch HighBranch { get; set; }

        public ICollection <qvBranch> LowBranches { get; set; }
        public ICollection <qvDepartment> Departments { get; set; }
    }
}
