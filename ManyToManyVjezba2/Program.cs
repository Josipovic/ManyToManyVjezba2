using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyVjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            CollegeContext db = new CollegeContext();

            College ferit = new College();
            ferit.CollegeName = "FERIT";
            ferit.Adress = "Osijek";

            College filozofski = new College();
            filozofski.CollegeName = "filozofski";
            filozofski.Adress = "Osijek";

            College poljoprivredni = new College();
            poljoprivredni.CollegeName = "poljoprivredni";
            poljoprivredni.Adress = "Osijek";


            Proffesor ivo = new Proffesor();
            ivo.Name = "ivo";
            ivo.LastName = "ivic";
            ivo.NumberOfWorkHours = 8;


            Proffesor ivan = new Proffesor();
            ivan.Name = "ivan";
            ivan.LastName = "ivanovic";
            ivan.NumberOfWorkHours = 8;

            Proffesor ante = new Proffesor();
            ante.Name = "ante";
            ante.LastName = "antic";
            ante.NumberOfWorkHours = 8;

            ferit.Proffesor.Add(ivo);
            ferit.Proffesor.Add(ante);
            poljoprivredni.Proffesor.Add(ante);
            filozofski.Proffesor.Add(ivan);
            ferit.Proffesor.Add(ivan);

            db.Colleges.Add(ferit);
            db.Colleges.Add(poljoprivredni);
            db.Colleges.Add(filozofski);

            db.SaveChanges();

            foreach (var c in db.Colleges) {
                Console.WriteLine(c.CollegeName + "  " + c.Adress);
                foreach (var p in c.Proffesor) {

                    Console.WriteLine("     " + p.Name + "  "+p.LastName+ "  " + p.NumberOfWorkHours);
                }
            }
            Console.Read();

        }
    }
}
