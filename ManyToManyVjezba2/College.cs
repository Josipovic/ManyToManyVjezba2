using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyVjezba2
{
    public class College
    {
        public int  Id { get; set; }
        public string CollegeName { get; set; }
        public string Adress { get; set; }

        public  virtual List<Proffesor>Proffesor { get; set; }

        public College()
        {
            Proffesor = new List<Proffesor>();
        }
    }
}
