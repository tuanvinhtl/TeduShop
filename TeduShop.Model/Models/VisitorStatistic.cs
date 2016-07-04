using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid ID { set; get; }  

        public DateTime VisitedDate { set; get; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string IPAddress { set; get;}
    }
}
