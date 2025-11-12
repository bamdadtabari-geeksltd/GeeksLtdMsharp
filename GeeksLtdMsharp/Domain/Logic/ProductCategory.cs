using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public partial class ProductCategory
    {
        public async Task UpdateName(string name)
        {
            await Database.Update(this, x => x.Name = name);
        }
    }
}
