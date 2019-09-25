using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyVjezba2
{
    class CollegeContext:DbContext
    {
        public DbSet<College>Colleges { get; set; }
        public  DbSet<Proffesor>Proffesors { get; set; }

    }
}
