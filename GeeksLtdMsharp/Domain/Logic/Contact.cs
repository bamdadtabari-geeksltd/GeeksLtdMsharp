using Olive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olive;

namespace Domain
{
    public partial class Contact
    {
        public static Task<IEntity> FindByName(string name)
        {
            return Database.FirstOrDefault<Contact>(c => c.Name == name).AsTask<Contact, IEntity>();
        }

        protected override Task OnValidating(EventArgs e)
        {
            Name = FirstName + " " + LastName;
            return base.OnValidating(e);
        }
    }
}
