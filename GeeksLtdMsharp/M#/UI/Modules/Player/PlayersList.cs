using MSharp;

namespace Modules
{
    public class PlayersList : ListModule<Domain.Player>
    {
        public PlayersList()
        {
            HeaderText("Tennis players")
                .ShowHeaderRow();

            ImageColumn("Photo").ImageUrl("@item.Photo").OnClick(x => x.Go<Player.ViewPage>()
                .Send("item", "item.ID"));

            Column(x => x.Name);

            CustomColumn().DisplayExpression("@await item.Fans.Count()").LabelText("Number of fans");

            ButtonColumn("Register to support")
                .OnClick(x => x.Go<Fan.FanFormPage>()
                    .Send("player", "item.ID"));

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.Go<Player.EnterPage>()
                    .Send("item", "item.ID")
                    .SendReturnUrl());

            ButtonColumn("Delete").Icon(FA.Remove)
                .OnClick(x => x.DeleteItem());

            Button("New tennis player").Icon(FA.Plus)
                .OnClick(x => x.Go<Player.EnterPage>()
                    .SendReturnUrl());
        }
    }
}