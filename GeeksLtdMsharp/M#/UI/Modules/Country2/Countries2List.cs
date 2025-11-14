using MSharp;

namespace Modules
{
    public class Countries2List : ListModule<Domain.Country2>
    {
        public Countries2List()
        {
            HeaderText("Countries");

            Column(x => x.Name);

            Column(x => x.Code);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.Go<Country2.EnterPage>()
                    .Send("item", "item.ID")
                    .SendReturnUrl());

            Button("New Country").Icon(FA.Plus)
                .OnClick(x => x.Go<Country2.EnterPage>().SendReturnUrl());
        }
    }
}