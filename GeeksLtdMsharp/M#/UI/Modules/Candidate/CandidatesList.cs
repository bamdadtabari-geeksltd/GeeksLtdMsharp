using MSharp;

namespace Modules
{
    public class CandidatesList : ListModule<Domain.Candidate>
    {
        public CandidatesList()
        {
            HeaderText("[#BUTTONS(NewCandidate)#][#BUTTONS(DeleteSelectedCandidates)#]Candidates")
                .ShowHeaderRow()
                .ShowFooterRow()
                .SelectCheckbox();

            Search(GeneralSearch.AllFields).Label("Find:");

            SearchButton("Search").OnClick(x => x.Reload());

            Column(x => x.DateAdded);

            Column(x => x.FirstName);

            Column(x => x.LastName);

            Column(x => x.Email);

            Column(x => x.Telephone).DisplayMode(DisplayMode.Selectable);

            Column(x => x.ConveringLetter).DisplayMode(DisplayMode.Selectable);

            Column(x => x.Status);

            ButtonColumn("Option Name").RepeatDataSource("item.Status.GetPossibleChanges()")
                .RepeatDataSourceType("Status")
                .SeperatorTemplate("|")
                .Text("@option.Name")
                .OnClick(x =>
                {
                    x.CSharp("item.UpdateStatus(option);");
                    x.Reload();
                })
                .Style(ButtonStyle.Link);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.Go<Candidate.EnterPage>()
                .Send("item", "item.ID")
                .SendReturnUrl());

            ButtonColumn("Delete").Icon(FA.Remove)
                    .HeaderText("Delete").GridColumnCssClass("actions")
                    .ConfirmQuestion("Are you sure you want to delete this Candidate?")
                    .CssClass("btn-danger")
                    .OnClick(x =>
                    {
                        x.DeleteItem();
                        x.Reload();
                    });

            Button("New Candidate").Icon(FA.Plus)
                .CssClass("pull-right")
                .OnClick(x => x.Go<Candidate.EnterPage>()
                .SendReturnUrl());

            Button("Delete selected candidates")
                .CssClass("pull-right")
                .OnClick(x =>
                {
                    x.CSharp("await Database.Delete<Candidate>(await info.SelectedItems);");
                    x.Reload();
                });

            Button("Export to CSV")
                .MarkupTemplate("Not to be redistributed. [#Button#]")
                .OnClick(x => x.Export(ExportFormat.Csv));
        }
    }
}
