using MSharp;

namespace Modules
{
    public class ClientForm : FormModule<Domain.Client>
    {
        public ClientForm()
        {
            HeaderText("Client details");

            Field(x => x.Company);

            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.ReturnToPreviousPage();
                });
        }
    }
}