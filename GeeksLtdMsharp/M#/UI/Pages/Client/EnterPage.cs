using MSharp;

namespace Client
{
    class EnterPage : SubPage<ClientPage>
    {
        public EnterPage()
        {
            Add<Modules.ClientForm>();
        }
    }
}