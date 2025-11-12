using MSharp;

namespace Modules
{
    public class PropertyForm : FormModule<Domain.Property>
    {
        public PropertyForm()
        {
            HeaderText("Property Details");
            ValidationStyle(WarningStyle.MessageBox);

            Field(x => x.Name).Mandatory().AsTextbox();
            Field(x => x.Price).AsNumericUpDown();
            Field(x => x.Owner).Mandatory().AsTextbox();
            Field(x => x.Age).AsNumericUpDown();

            MergedForm(x => x.Address, s =>
            {
                s.field.AddressLine1();
                s.field.AddressLine2();
                s.field.Town();
                s.field.PostalCode();
            });

            Button("Cancel").CausesValidation(false)
                .OnClick(x => x.CloseModal()).ConfirmQuestion("are you sure you wanna cancel the Process?");

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
