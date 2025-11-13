using MSharp;

namespace Developer
{
    class EnterPage : SubPage<DeveloperPage>
    {
        public EnterPage()
        {
            Add<Modules.DeveloperForm>();
        }
    }
}