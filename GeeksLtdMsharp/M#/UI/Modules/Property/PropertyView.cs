using MSharp;

namespace Modules
{
    public class PropertyView : ViewModule<Domain.Property>
    {
        public PropertyView()
        {
            HeaderText("Property Details");
            Field(x => x.Name);
            Field(x => x.Price);
            Field(x => x.Owner);
            Field(x => x.Age);
            ////Field(x => x.Address.Result.AddressLine1).DataSource("item.Address.AddressLine1");
            //Field(x => x.Address.Result.AddressLine2);
            //Field(x => x.Address.Result.Town);
            //Field(x => x.Address.Result.PostalCode);
            
            Button("Close").CausesValidation(false)
                .OnClick(x => x.CloseModal());
        }
    }
}
