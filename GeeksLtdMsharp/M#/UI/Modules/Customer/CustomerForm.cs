using MSharp;

namespace Modules
{
    public class CustomerForm : FormModule<Domain.Customer>
    {
        public CustomerForm()
        {
            HeaderText("Customer details");

            Field(x => x.Name).Label("Customer name");

            Field(x => x.Reseller).Control(ControlType.VerticalRadioButtons);

            AutoSet(x => x.Country);

            Button("Cancel").OnClick(x => x.CloseModal());

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.CloseModal(Refresh.Full);
                });
        }
    }
}