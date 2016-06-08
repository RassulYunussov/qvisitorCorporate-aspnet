using qvisitorCorporateaspnet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace qvisitorCorp.Models
{
    [Table("qvVisitor")]
    public class qvVisitor
    {
	    public int Id {get;set;}
	    public string name {get;set;}
	    public string surname {get;set;}
	    public string patronymic {get;set;}
	    
        public int GenderId { get; set; }
        [ForeignKey("GenderId")]
        public virtual qvGender Gender { get; set; }

        
        public virtual ICollection <qvVisitiorPhoto> VisitorPhotos { get; set; }
        public virtual ICollection <qvVisitorDoc> VisitorDocs { get; set; }
        public virtual ICollection <qvVisitorScan> VisitorScans { get; set; }
        public virtual ICollection <qvVisitorLuggage> VisitorLuggage { get; set; }

        public DateTime birthdate { get; set; }

        public qvVisitor(){}
       
     }
}
