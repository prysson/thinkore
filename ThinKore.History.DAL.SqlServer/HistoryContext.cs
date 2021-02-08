using Microsoft.EntityFrameworkCore;
using System;

namespace ThinKore.History.DAL.SqlServer
{
    public class HistoryContext : DbContext
    {
        public HistoryContext(DbContextOptions options) : base(options)
        {

        }


    }
}
