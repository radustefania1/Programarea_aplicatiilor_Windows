using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_2
{
    class BiletVIP:Bilet
    {
        bool IncludePopcorn { get; set; }
        bool IncludeBautura { get; set; }
        public BiletVIP(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza,bool includeBautura,bool includePopcorn) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
        {
            IncludePopcorn = includePopcorn;
            IncludeBautura = includeBautura;
        }

        public double GetExtras() {
            double suma = 0;
            if (IncludePopcorn)
                suma += 15;
            if (IncludeBautura)
                suma += 10;
            return suma;
        }
        public override double CalculeazaPretFinal()
        {
            return PretBaza+GetExtras();
        }
    }
}
