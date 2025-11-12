using Domain;
using MSharp;

namespace Modules
{
    class ProductForm : FormModule<Domain.Product>
    {
        public ProductForm()
        {
            HeaderText("Product Details");
            ValidationStyle(WarningStyle.MessageBox);
            ButtonsLocation("Top");

            // just for test
            AutoSet(x => x.ProductCategory);

            Field(x => x.Name).Mandatory().AsTextbox();

            Field(x => x.ProductionDate_time)
                .WatermarkText("dd/mm/yyyy")
                .Control(ControlType.DateAndTimePicker);
            Field(x => x.IsFood).Label("Type")
                .Control(ControlType.HorizontalRadioButtons)
                .FalseText("Not food")
                .LabelCssClass("normal");
            Field(x => x.ProductWebsite).NumberOfLines(5);

            Field(x => x.Photo).Control(ControlType.FileUpload);

            CustomField().Label("Categories")
             .PropertyName("ProductCategory").PropertyType("ProductCategory")
             .DataSource("await Database.GetList<ProductCategory>()")
             .ItemValueExpression("item.ID").Control(ControlType.DropdownList);

            Button("Cancel").CausesValidation(false)
               .OnClick(x => x.CloseModal()).ConfirmQuestion("are you sure you wanna cancel the proccess?");

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.RunInTransaction(false);
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.CloseModal(Refresh.Ajax);
                });
        }
    }
}
