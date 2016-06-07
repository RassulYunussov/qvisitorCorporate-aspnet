using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    public class qvOrderComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }

        public qvOrderComment() { }
    }
}
