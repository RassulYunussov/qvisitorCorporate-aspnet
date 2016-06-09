using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace qvisitorCorp.Models
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
