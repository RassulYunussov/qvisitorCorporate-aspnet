using qvisitorCorporateaspnet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorp.Models
{
    [Table("qvCountry")]
    public class qvCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection <qvCity> qvCities { get; set; }
        public virtual ICollection <qvCompany> qvCompanies { get; set; }

        public qvCountry()
        {
        }
    }
}
