using MSharp;

namespace Modules
{
    public class AssetTypeForm : FormModule<Domain.AssetType>
    {
        public AssetTypeForm()
        {
            HeaderText("Asset Types details");

            Field(x => x.Name);

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