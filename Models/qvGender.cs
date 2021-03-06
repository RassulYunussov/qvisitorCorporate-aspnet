using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace qvisitorCorp.Models
{
  [Table("qvGender")]
    public class qvGender{
	public int    Id {get;set;}
 	public string Code {get;set;}
 	public string Name {get;set;}
    
    
 	public virtual ICollection <qvVisitor> Visitors { get;set; }
    public virtual ICollection <qvUserPassport> UserPassports { get; set; }

    public qvGender(){}
  }
}
