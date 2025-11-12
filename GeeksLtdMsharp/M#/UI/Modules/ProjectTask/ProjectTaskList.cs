using MSharp;
using ProjectTask;

namespace Modules
{
    public class ProjectTaskList : ListModule<Domain.ProjectTask>
    {
        public ProjectTaskList()
        {
            ShowFooterRow()
                .ShowHeaderRow()
                .UseDatabasePaging(false)
                .HeaderText("Tasks")
                .PageSize(10);

            LinkColumn("View").HeaderText("View")
                .OnClick(x => x.Go<ViewPage>()
                    .Send("item", "item.ID")
                    .SendReturnUrl());

            Column(x => x.Project);

            Column(x => x.Title);

            Column(x => x.Description);

            Column(x => x.Done).LabelText("Is done?");

            ButtonColumn("Edit").Icon(FA.Edit)
                .HeaderText("Edit")
                .OnClick(x => x.PopUp<EditPage>()
                    .Send("item", "item.ID")
                    .SendReturnUrl(false));

            ButtonColumn("Delete")
                .HeaderText("Delete")
                .ConfirmQuestion("Are you sure you want to delete this Task?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("Add task").Icon(FA.Plus)
                .OnClick(x => x.Go<EnterPage>().SendReturnUrl());
        }
    }
}