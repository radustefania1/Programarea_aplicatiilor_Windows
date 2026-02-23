using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_1_Paw
{
    class Student
    {

        public string Nume { get; set; }
        public int Grupa { get; set; }
        public double? NotaExamen { get; set; }
        public double? NotaTest { get; set; }  //se pune ? ca sa arate faptul ca se poate ca un student sa nu aiba not la una din cele trei metode de evaluare
        public double? NotaProiect {get;set;}


        public double? Media 
        {
            get 
            {
                if (!NotaExamen.HasValue)
                    return null;
                return NotaExamen * 0.6 + (NotaTest.HasValue ? NotaTest : 0) * 0.25 + (NotaProiect.HasValue ? NotaProiect : 0) * 0.15;
            }
        }
    }
}
