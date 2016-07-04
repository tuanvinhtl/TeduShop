using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [StringLength(256)]
        public string Name { set; get; }

        [StringLength(256)]
        [Column(TypeName =("varchar"))]
        public string Alias { set; get; }

        public int? ParentID { set; get; }

        [StringLength(500)]
        public string Images { set; get; }

        public bool? HomeFlag { set; get; }


        public virtual IEnumerable<Product> Products { set; get; }
    }
}
