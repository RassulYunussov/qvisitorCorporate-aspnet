using qvisitorCorp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvCity")]
    public class qvCity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryID { get; set; }
        [ForeignKey("CountryID")]
        public virtual qvCountry Country { get; set; }

        public virtual ICollection <qvObject> qvObjects { get; set; }

        public qvCity() { }
}
}
