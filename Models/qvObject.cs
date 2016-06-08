﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvObject")]
    public class qvObject
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual qvCity City { get; set; }

        public virtual ICollection<qvCheckPoint> CheckPoints { get; set; }

        public qvObject() { }
    }
}
