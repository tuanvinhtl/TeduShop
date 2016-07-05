using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        string MetaKeywork { set; get; }
        string Description { set; get; }
        int? DisplayOrder { set; get; }
        bool Status { set; get; }
    }
}
