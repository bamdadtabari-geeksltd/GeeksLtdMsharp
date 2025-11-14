using MSharp;

namespace Modules
{
    public class PlayerForm : FormModule<Domain.Player>
    {
        public PlayerForm()
        {
            HeaderText("Tennis player details");

            Field(x => x.Name);

            Field(x => x.Photo);

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