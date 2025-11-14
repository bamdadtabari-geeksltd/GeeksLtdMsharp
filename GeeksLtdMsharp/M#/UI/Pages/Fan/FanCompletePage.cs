using MSharp;

namespace Fan
{
    public class FanCompletePage : SubPage<TennisPlayerPage>
    {
        public FanCompletePage()
        {
            Add<Modules.FanCompleteForm>();
        }
    }
}