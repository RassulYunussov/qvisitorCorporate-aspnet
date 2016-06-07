using System; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations.Schema; 
using System.Linq; 
using System.Threading.Tasks; 

namespace qvisitorCorp.Models
{
  [Table("qvGender")]
    public class qvGender{
	public int    Id {get;set;}
 	public string Code {get;set;}
 	public string Name {get;set;}
    
    
 	public virtual ICollection <qvVisitor> qvVisitors { get;set; }

 	public qvGender(){}
  }
}
