using Microsoft.EntityFrameworkCore;
using System;

namespace ThinKore.Persistence.SqlServer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
