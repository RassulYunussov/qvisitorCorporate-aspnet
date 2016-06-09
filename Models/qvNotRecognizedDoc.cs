using System.ComponentModel.DataAnnotations.Schema;

namespace qvisitorCorp.Models
{
    [Table ("qvNotRecognizedDoc")]
    public class qvNotRecognizedDoc
    {
        public int Id { get; set; }
        public byte[] Scan{ get; set; }

        public int CheckPointId { get; set; }
        [ForeignKey("CheckPointId")]
        public qvCheckPoint CheckPoint { get; set; }
    }
}
