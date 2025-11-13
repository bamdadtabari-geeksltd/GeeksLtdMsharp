using MSharp;

namespace Modules
{
    public class RegisterForm : FormModule<Domain.Register>
    {
        public RegisterForm()
        {
            HeaderText("Register today!");

            Header("Please register in order to access our wonderful website.");

            Field(x => x.FirstName);

            Field(x => x.LastName);

            Field(x => x.DateOfBirth).Control(ControlType.DatePicker);

            Field(x => x.Email);

            Field(x => x.Password);

            Field(x => x.InvitationCode).HeaderText("<h2>By invitation only</h2>").Label("Early registration secret code");

            SupportsEdit(false);

            Button("Register")
                .IsDefault()
                .OnClick(x =>
                {
                    x.If("info.InvitationCode != \"SuperSecretFormula\"")
                        .GentleMessage("Invalid registration key.")
                        .AndExit();
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                });
        }
    }
}