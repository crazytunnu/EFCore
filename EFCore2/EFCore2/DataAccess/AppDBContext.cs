using Microsoft.EntityFrameworkCore;

namespace EFCore2.DataAccess
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions ops) : base(ops)
        {

        }
    }
}
