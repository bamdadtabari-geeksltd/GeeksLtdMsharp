using Microsoft.Extensions.DependencyInjection;
using Olive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public partial class Product
    {
        protected override Task OnValidating(EventArgs e)
        {
            Thumbnail = this.Photo.Clone();
            return base.OnValidating(e);
        }

    }
}
