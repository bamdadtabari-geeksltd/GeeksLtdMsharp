using MSharp;

namespace Modules
{
    public class FanCompleteForm : FormModule<Domain.Fan>
    {
        public FanCompleteForm()
        {
            HeaderText("Complete your fan registeration");

            Field(x => x.Player).Readonly();

            Field(x => x.Name).Readonly().Label("Your name");

            Field(x => x.DateOfBirth).Mandatory();

            Field(x => x.SupportComments);

            OnBeforeSave("Befor saving form").Code("item.IsRegistrationCompleted = true;");

            Button("Complete registration").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.Go<Player.ViewPage>().Send("item", "info.Item.PlayerId");
                });
        }
    }
}