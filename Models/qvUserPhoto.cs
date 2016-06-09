using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvUserPhoto")]
    public class qvUserPhoto
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public DateTime PhotoDate { get; set; }

    }
}
