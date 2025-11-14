using MSharp;

namespace Domain
{
    public class Player : EntityType
    {
        public Player()
        {
            String("Name").Mandatory();
            
            OpenImage("Photo").AutoOptimize()
                .Height(400)
                .Width(400);

            InverseAssociate<Fan>("Fans", "Player");
        }
    }
}