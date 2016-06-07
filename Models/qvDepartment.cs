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

        [Column ("branchid")]
        public qvBranch Branch { get; set; }

        public ICollection<qvHotEntrance> HotEntrances { get; set; }

        public qvDepartment() { }
}
}
