using System.Runtime.InteropServices.JavaScript;
using MSharp;

namespace Domain
{
    class Property : EntityType
    {
        public Property()
        {
            String("Name").Mandatory();
            String("Owner").Mandatory();
            Int("Age");
            Money("Price").Mandatory();

            InverseAssociate<Address>("Address", "Property").Mandatory();
        }
    }
}