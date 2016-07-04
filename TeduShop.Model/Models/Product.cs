using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [StringLength(256)]
        public string Name { set; get; }

        [Required]
        [StringLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        [Required]
        [StringLength(500)]
        public string Images { set; get; }

        [Required]
        [Column(TypeName ="xml")]
        public string MoreImages { set; get; }

        public decimal? Price { set; get; }

        public decimal? Promotion { set; get; }

        public int? Warranty { set; get; }

        [Required]
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }


        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
