using MSharp;

namespace Modules
{
    public class RegistrationForm : FormModule<Domain.Registration>
    {
        public RegistrationForm()
        {
            HeaderText("Register for Event");

            Field(x => x.FirstName).Mandatory();

            Field(x => x.LastName).Mandatory();

            Field(x => x.Email).Mandatory();

            Field(x => x.IsSubscribed)
                .Label("Interested in our Newsletter?")
                .TrueText("Yes, I'd like to subscribe and receive your newsletter")
                .FalseText("No, thanks.");

            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.RunInTransaction(false);
                    x.SaveInDatabase();
                    x.CSharp("await info.Item.SendConfirmation();");
                    x.Display("Saved successfully.")
                        .DisplayOnModule();
                });
        }
    }
}