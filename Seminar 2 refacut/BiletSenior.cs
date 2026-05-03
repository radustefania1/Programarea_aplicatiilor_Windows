using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_2
{
    class BiletSenior:Bilet
    {
        private double _procentReducere = 0.3;
        public int VarstaClient { get; set; }
        public BiletSenior(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza, int varstaClient) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza) {
            if (varstaClient < 60)
            {
                throw new ArgumentException("Varsta invalida");
            }
            VarstaClient = varstaClient;
        }

        public override double GetReducere()
        {
            return PretBaza*_procentReducere;
        }
    }
}
