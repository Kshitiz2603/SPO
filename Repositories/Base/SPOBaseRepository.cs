using System.Runtime.CompilerServices;
using Interfaces;

namespace Repositories
{
    public class SPOBaseRepository : ISPOBaseRepository
    {
        protected IDbManager _db {get; set; }

        public SPOBaseRepository(IDbManager dbManager)
        {
            _db = dbManager;
        }

        // Add common database operations here
    }
}