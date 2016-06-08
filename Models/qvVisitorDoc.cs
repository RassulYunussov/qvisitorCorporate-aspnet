using qvisitorCorp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace qvisitorCorporateaspnet.Models
{
    [Table ("qvVisitorDoc")]
    public class qvVisitorDoc
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpireDate { get; set; }

        public int VisitorId { get; set; }
        [ForeignKey("VisitorId")]
        public qvVisitor Visitor { get; set; }

    }
}
