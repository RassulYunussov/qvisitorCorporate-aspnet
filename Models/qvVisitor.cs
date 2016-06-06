using System; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations.Schema; 
using System.Linq; 
using System.Threading.Tasks; 

  
namespace qvisitorCorp.Models
{
    [Table("qvVisitor")]
    public class qvVisitor{
	public int qvVisitorId {get;set;}
	public string name {get;set;}
	public string surname {get;set;}
	public string patronymic {get;set;}
	public DateTime birthdate {get;set;}
	public int genderId {get;set;}	
        public qvGender qvGender {get;set;}
        public qvVisitor(){}
       
     }
}
