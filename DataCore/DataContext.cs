using System;
using Microsoft.EntityFrameworkCore;

namespace DataCore
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public virtual DbSet<DataXml> XmlData { get; set; }

    }
}
