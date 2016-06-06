using qvisitorCorp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    public class qvCompany
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public qvCountry Country { get; set; }
    public ICollection<qvCompany> Companies { get; set; }
    public qvCompany() { }
    }
}
