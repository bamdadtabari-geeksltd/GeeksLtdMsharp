using MSharp;

namespace Project2
{
    class EnterPage : SubPage<Project2Page>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.Project2Form>();
        }
    }
}