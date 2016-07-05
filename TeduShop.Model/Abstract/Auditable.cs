using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }

        [MaxLength(256)]
        public string MetaKeywork { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? DisplayOrder { set; get; }
   
        public bool Status { set; get; }
    }
}
