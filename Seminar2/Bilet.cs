using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//nu potisa ai doua enum uri care au aceeasi variabila in {} 

namespace Seminar2
{
    public class Bilet : IPretCalculabil, IValidabil
    {
        public string NumeFilm { get; set; }
        public int NumarSala { get; set; }
        public TipFilm TipFilm { get; set; }
        public DateTime ExpiraLa { get; set; }
        public Client Client { get; set; }

        private int _numarLoc;
        public int NumarLoc 
        {
            get { return _numarLoc; }

            set
            {
                if (value < 1 || value > 200)
                    throw new ArgumentOutOfRangeException("Numarul locului este indisponibil");
                else
                    _numarLoc = value;
            }
        }

        private int _pretBaza;
        public int PretBaza
        {
            get { return _pretBaza; }

            set
            {
                if (value > 0)
                    throw new ArgumentOutOfRangeException("Pretul de baza este indisponibil");
                else
                    _pretBaza = value;
            }
        }

        public Bilet(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, int pretBaza)
        {
            NumeFilm = numeFilm;
            NumarSala = numarSala;
            TipFilm = tipFilm;
            ExpiraLa = expiraLa;
            Client = client;
            NumarLoc = numarLoc;
            PretBaza = pretBaza;
        }   


        public virtual double CalculeazaPretFinal()
        {
            return PretBaza - GetReducere();
        }

        public virtual bool EsteValid()
        {
            return ExpiraLa > DateTime.Now;              //DateTime.UtcNow - daca vrem sa comparam cu timpul universal, nu cu timpul local
        }

        public virtual double GetReducere()
        {
            return 0;
        }
    }
}
