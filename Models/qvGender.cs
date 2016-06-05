using System; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations.Schema; 
using System.Linq; 
using System.Threading.Tasks; 

namespace qvisitorCorp.Models
{
  [Table("qvGender")]
  public class qvGender{
	public int genderId {get;set;}
 	public string code {get;set;}
 	public string name {get;set;}
 	public ICollection<qvVisitor> qvVisitors {get;set;}
 	public qvGender(){}
  }
}
