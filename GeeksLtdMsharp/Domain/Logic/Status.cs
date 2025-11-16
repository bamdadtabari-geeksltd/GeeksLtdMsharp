using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public partial class Status
    {
        public IEnumerable<Status> GetPossibleChanges()
        {
            if (this == Pending)
            {
                return new[] { Interviewed, Offered, Rejected };
            }

            if (this == Interviewed)
            {
                return new[] { Offered, Rejected };
            }

            return Enumerable.Empty<Status>();
        }
    }
}