using Olive;
using System;
using System.Threading.Tasks;

namespace Domain
{
    public partial class Fan
    {
        protected override Task OnValidating(EventArgs e)
        {
            if (this.StartDate == default(DateTime))
            {
                this.StartDate = LocalTime.Now;
            }

            return base.OnValidating(e);
        }
    }
}