using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [StringLength(256)]
        public string Name { set; get; }

        [Required]
        [StringLength(256)]
        public string Description { set; get; }

        [Required]
        [StringLength(500)]
        public string Image { set; get; }

        [Required]
        [StringLength(500)]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        [Required]
        public bool Status { set; get; }


    }
}
