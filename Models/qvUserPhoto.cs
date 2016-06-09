using System;
using System.ComponentModel.DataAnnotations.Schema;

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
