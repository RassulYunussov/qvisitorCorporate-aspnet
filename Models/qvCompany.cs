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

        [Column("countryid")]
        public int CounryId { get; set; }
        public qvCountry Country { get; set; }

        public ICollection<qvCompany> Companies { get; set; }

        public qvCompany() { }
    }
}
