using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyVjezba2
{
   public class Proffesor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int NumberOfWorkHours { get; set; }

        public  virtual List<College>College { get; set; }
        public Proffesor()
        {
            College = new List<College>();
        }

    }
}
