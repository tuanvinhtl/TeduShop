using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [StringLength(256)]
        public string Name { set; get; }

        [Required]
        [StringLength(256)]
        public string Department { set; get; }

        [Required]
        [StringLength(256)]
        public string Skype { set; get;}

        [Required]
        [StringLength(256)]
        public string Mobile { set; get; }

        [Required]
        [StringLength(256)]
        public string Yahoo { set; get; }

        [Required]
        [StringLength(256)]
        public string Facebook { set; get; }

        public bool Status { set; get; }



    }
}
