using Domain;
using MSharp;

namespace Modules
{
    class ProductCategoryForm : FormModule<Domain.ProductCategory>
    {
        public ProductCategoryForm()
        {
            HeaderText("Product Category Details");
            ValidationStyle(WarningStyle.MessageBox);
            ButtonsLocation("Top");

            Field(x => x.Name).Mandatory().AsTextbox();

            MasterDetail(x => x.Products, s =>
            {
                s.HeaderText("Serviced Properties");

                s.Field(x => x.Name).Mandatory().AsTextbox();

                s.Field(x => x.ProductionDate_time)
                    .WatermarkText("dd/mm/yyyy")
                    .Control(ControlType.DateAndTimePicker);
                s.Field(x => x.IsFood).Label("Type")
                    .Control(ControlType.HorizontalRadioButtons)
                    .FalseText("Not food")
                    .LabelCssClass("normal");
                s.Field(x => x.ProductWebsite).NumberOfLines(5);

                s.Field(x => x.Photo).Control(ControlType.FileUpload);

                s.Button("Add Product").OnClick(x => x.AddMasterDetailRow());
            }).MinCardinality(1);

            Button("Cancel").CausesValidation(false)
               .OnClick(x => x.CloseModal()).ConfirmQuestion("are you sure you wanna cancel the proccess?");

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.CloseModal(Refresh.Ajax);
                });
        }
    }
}
