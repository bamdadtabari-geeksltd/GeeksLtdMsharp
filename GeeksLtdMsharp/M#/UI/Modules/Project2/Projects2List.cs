using MSharp;

namespace Modules
{
    public class Projects2List : ListModule<Domain.Project2>
    {
        public Projects2List()
        {
            HeaderText("Projects")
                .ShowHeaderRow()
                .ShowFooterRow();

            Column(x => x.Name);

            Column(x => x.TotalWorkHours).FooterFormula(AggregateFormula.Sum);

            ButtonColumn("Edit").Icon(FA.Edit)
                .HeaderText("Edit").GridColumnCssClass("actions")
                .OnClick(x => x.Go<Project.EnterPage>()
                    .SendReturnUrl()
                    .Send("item", "item.ID"));

            ButtonColumn("Delete").Icon(FA.Remove)
                .HeaderText("Delete").GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Project?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("Add project").Icon(FA.Plus)
                .OnClick(x => x.Go<Project2.EnterPage>()
                    .SendReturnUrl());
        }
    }
}