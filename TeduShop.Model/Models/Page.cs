using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [StringLength(256)]
        public string Name { set; get; }

        [Required]
        public string Content { set; get; }

        [Required]
        [StringLength(500)]
        public string Description { set; get; }

        [StringLength(250)]
        public string MetaKeywork { set; get; }

        public bool Status { set; get; }
    }
}
