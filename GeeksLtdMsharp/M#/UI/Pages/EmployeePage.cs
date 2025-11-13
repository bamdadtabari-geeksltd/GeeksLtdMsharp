using MSharp;

public class EmployeePage : RootPage
{
    public EmployeePage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.EmployeesList>();
    }
}