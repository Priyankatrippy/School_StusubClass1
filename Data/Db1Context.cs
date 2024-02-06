using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp_1._44_PracticeProject.Models;

namespace WebApp_1._44_PracticeProject.Data
{
    public class Db1Context : DbContext
    {
        public Db1Context (DbContextOptions<Db1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApp_1._44_PracticeProject.Models.Class1> Class1 { get; set; } = default!;

        public DbSet<WebApp_1._44_PracticeProject.Models.Subject>? Subject { get; set; }

        public DbSet<WebApp_1._44_PracticeProject.Models.Student>? Student { get; set; }
    }
}
