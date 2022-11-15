using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSystemTextJsonBugTest
{
    internal class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();

            var thing = System.Text.Json.JsonSerializer.Serialize("testing");
            Console.WriteLine(thing);
        }
    }
}
