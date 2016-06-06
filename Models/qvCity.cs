using qvisitorCorp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    public class qvCity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public qvCountry qvCountries { get; set; }

        public qvCity() { }
}
}
