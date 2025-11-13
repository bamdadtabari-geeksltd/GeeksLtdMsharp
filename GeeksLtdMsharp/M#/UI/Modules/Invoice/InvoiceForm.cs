using MSharp;

namespace Modules
{
    public class InvoiceForm : FormModule<Domain.Invoice>
    {
        public InvoiceForm()
        {
            HeaderText("Invoice details");

            RequestParam("clientId");

            Field(x => x.Client);
            Field(x => x.Date).Control(ControlType.DatePicker);
            Field(x => x.Amount);
            Field(x => x.Description);

            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.ReturnToPreviousPage();
                });

            AutoSet(x => x.Client);
        }
    }
}