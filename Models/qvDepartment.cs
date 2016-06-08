using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvDepartment")]
    public class qvDepartment
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual qvBranch Branch { get; set; }

        public virtual ICollection <qvHotEntrance> HotEntrances { get; set; }

        public qvDepartment() { }
}
}
