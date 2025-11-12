using MSharp;

namespace Domain
{
    class Product : EntityType
    {
        public Product()
        {
            String("Name").Mandatory().RequiredValidationMessage("Please Set Product Name");
            DateTime("Production date/time").Mandatory()
               .RequiredValidationMessage("Please add the time and date!");
            Bool("Is Food").TrueText("Food").FalseText("Not food").Mandatory();
            String("Product website").Max(200)
                .Mandatory()
                .Accepts(TextPattern.InternetURL)
                .FormatValidationMessage("Please enter the product's website.");

            OpenImage("Photo").Mandatory().ValidExtensions("png, jpeg, jpg");//.SecureAccess(false);
            OpenImage("Thumbnail").OptimizationQuality(70).Width(100).Height(50);//.SecureAccess(false);

            Associate<ProductCategory>("Product Category").Mandatory().DatabaseIndex();
        }
    }
}