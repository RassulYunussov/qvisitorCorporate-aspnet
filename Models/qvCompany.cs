using qvisitorCorp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvCompany")]
    public class qvCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CounryId { get; set; }
        [ForeignKey("CounryId")]
        public virtual qvCountry Country { get; set; }

        public virtual ICollection<qvCompany> Companies { get; set; }

        public qvCompany() { }
    }
}
