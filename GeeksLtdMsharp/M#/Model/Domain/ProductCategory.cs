using MSharp;

namespace Domain
{
    class ProductCategory : EntityType
    {
        public ProductCategory()
        {
            String("Name");
            InverseAssociate<Product>("Products", "ProductCategory").Mandatory().OnDelete(CascadeAction.ThrowWarning);
        }
    }
}