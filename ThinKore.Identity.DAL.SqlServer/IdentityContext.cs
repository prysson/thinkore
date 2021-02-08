using Microsoft.EntityFrameworkCore;
using System;

namespace ThinKore.Identity.DAL.SqlServer
{
    public class IdentityContext : DbContext
    {
        public IdentityContext(DbContextOptions options) : base(options)
        {
        }
    }
}
