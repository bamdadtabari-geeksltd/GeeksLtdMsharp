using MSharp;

namespace Employee
{
    class EnterPage : SubPage<EmployeePage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.EmployeeForm>();
        }
    }
}