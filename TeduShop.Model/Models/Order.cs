using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [StringLength(256)]
        public string CustumerName { set; get; }

        [Required]
        [StringLength(256)]
        public string CustumerAddress { set; get; }

        [Required]
        [StringLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [StringLength(256)]
        public string CustomerMobile { set; get; }

        [Required]
        [StringLength(256)]
        public string CustomerMessage { set; get; }

        public DateTime? CreatedDate { set; get; }

        public DateTime? CreatedBy { set; get; }

        [Required]
        [StringLength(256)]
        public string PaymentMethod { set; get; }

        [Required]
        [StringLength(256)]
        public string PaymentStatus { set; get; }

        [Required]
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }
    }
}
