﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace qvisitorCorporateaspnet.Models
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

        
        public virtual ICollection <qvVisitiorPhoto> VisitorPhotoes { get; set; }
        public virtual ICollection <qvVisitorDoc> VisitorDocs { get; set; }
        public virtual ICollection <qvVisitorScan> VisitorScans { get; set; }
        public virtual ICollection <qvVisitorLuggage> VisitorLuggages { get; set; }
        public virtual ICollection <qvEntrance> Entrances { get; set; }

        public virtual ICollection <refOrderVisitor> RefOrderVisitors { get; set; }

        public DateTime birthdate { get; set; }

        public qvVisitor(){}
       
     }
}
