using Olive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MyStorageProvider : IBlobStorageProvider
    {
        public bool CostsToCheckExistence()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Blob blob)
        {
            throw new NotImplementedException();
        }

        public Task<bool> FileExistsAsync(Blob blob)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> LoadAsync(Blob blob)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Blob blob)
        {
            throw new NotImplementedException();
        }
    }
}
