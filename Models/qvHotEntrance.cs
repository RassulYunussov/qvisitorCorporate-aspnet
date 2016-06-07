using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    public class qvHotEntrance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string DocumentNumber { get; set; }
        public string Organization { get; set; }
        public string Attendant { get; set; }
        public string Comment { get; set; }

        public qvDepartment Department { get; set; }

    }
}
