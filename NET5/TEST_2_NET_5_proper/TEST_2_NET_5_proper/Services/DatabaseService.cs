using Test_2.Models;

namespace Test_2.Services
{
    public class DatabaseService : IDatabaseService
    {
        private s20353Context _context;
        public DatabaseService(s20353Context context)
        {
            _context = context;
        }

        //
    }
}
