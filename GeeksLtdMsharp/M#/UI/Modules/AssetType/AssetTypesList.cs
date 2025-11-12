using MSharp;

namespace Modules
{
    public class AssetTypesList : ListModule<Domain.AssetType>
    {
        public AssetTypesList()
        {
            HeaderText("Asset Types");

            Column(x => x.Name);

            ButtonColumn("Edit").Icon(FA.Edit)
                .HeaderText("Edit").GridColumnCssClass("actions")
                .OnClick(x => x.Go<AssetType.EnterPage>()
                    .Send("item", "item.ID")
                    .SendReturnUrl());

            ButtonColumn("Delete").Icon(FA.Remove)
                .HeaderText("Delete").GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Asset Type?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("Add Asset Type").Icon(FA.Plus)
                .OnClick(x => x.Go<AssetType.EnterPage>()
                    .SendReturnUrl());
        }
    }
}