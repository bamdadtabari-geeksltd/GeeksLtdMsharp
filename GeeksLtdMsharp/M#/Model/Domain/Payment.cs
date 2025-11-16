using MSharp;

namespace Domain
{
    public class Payment : EntityType
    {
        public Payment()
        {
            // we don't want to store payments
            DatabaseMode(DatabaseOption.Transient);

            IsInterface();

            String("Title");
        }
    }
}