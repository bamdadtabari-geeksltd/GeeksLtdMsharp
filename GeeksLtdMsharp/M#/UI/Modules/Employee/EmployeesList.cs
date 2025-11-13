using MSharp;

namespace Modules
{
    public class EmployeesList : ListModule<Domain.Employee>
    {
        public EmployeesList()
        {
            HeaderText("Employees")
                .ShowHeaderRow();

            Column(x => x.FirstName);

            Column(x => x.LastName);

            Column(x => x.Email).EmptyMarkup("N/A");

            Column(x => x.IDCard);

            Column(x => x.Warnings).DisplayExpression("@Html.Raw(item.Warnings)");

            ButtonColumn("Edit").Icon(FA.Edit)
                .HeaderText("Edit").GridColumnCssClass("actions")
                .OnClick(x => x.Go<Employee.EnterPage>()
                    .SendReturnUrl()
                    .Send("item", "item.ID"));

            ButtonColumn("Delete").Icon(FA.Remove)
                .HeaderText("Delete").GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Employee?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("New Employee").Icon(FA.Plus)
                .OnClick(x => x.Go<Employee.EnterPage>()
                    .SendReturnUrl());
        }
    }
}