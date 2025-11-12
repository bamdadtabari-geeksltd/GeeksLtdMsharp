using MSharp;

namespace Modules
{
    public class ProductView : ViewModule<Domain.Product>
    {
        public ProductView()
        {
            HeaderText("@item.Name Details");

            Field(x => x.Name);

            Field(x => x.IsFood);

            Field(x => x.Photo);
            Button("Back")
                .IsDefault()
                .Icon(FA.ChevronLeft)
                .OnClick(x => x.ReturnToPreviousPage());

            Button("Delete")
                .ConfirmQuestion("Are you sure you want to delete this Product?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.GentleMessage("Deleted successfully.");
                    x.ReturnToPreviousPage();
                });
        }
    }
}
