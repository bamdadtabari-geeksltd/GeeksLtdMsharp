using MSharp;

namespace Fan
{
    public class FanFormPage : SubPage<TennisPlayerPage>
    {
        public FanFormPage()
        {
            Add<Modules.FanForm>();
        }
    }
}