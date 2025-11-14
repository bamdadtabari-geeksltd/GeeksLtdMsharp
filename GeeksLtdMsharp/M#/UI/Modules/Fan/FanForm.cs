using MSharp;

namespace Modules
{
    public class FanForm : FormModule<Domain.Fan>
    {
        public FanForm()
        {
            HeaderText("Register to support: @info.Player.Name");

            Field(x => x.Email);

            Field(x => x.Name);

            Field(x => x.StartDate).Mandatory(false);

            AutoSet(x => x.Player);

            Button("Next").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.Go<Fan.FanCompletePage>().Send("item", "info.Item.ID");
                });
        }
    }
}