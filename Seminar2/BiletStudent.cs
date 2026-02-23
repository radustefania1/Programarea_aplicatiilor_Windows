using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class BiletStudent : Bilet
    {

        private double _procentReducere = 0.2;

        public string NumarLegitimatie { get; set; }
        public string Facultate { get;set; }

        public BiletStudent(
            string numeFilm,
            int numarSala,
            TipFilm tipFilm,
            DateTime expiraLa,
            Client client,
            int numarLoc,
            int pretBaza,
            string numarLegitimatie,
            string facultate)      //constructor pentru clasa derivata
            : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)  // inlantuiesc apelul catre clasa de baza 
        {
            NumarLegitimatie = numarLegitimatie;
            Facultate = Facultate;
        }

        public override double GetReducere()
        {
            return PretBaza * _procentReducere;
        }

        public override bool EsteValid()
        {
            return base.EsteValid();
                {
                return base.EsteValid() && !string.IsNullOrEmpty(NumarLegitimatie);
            }
        }
    }
}
