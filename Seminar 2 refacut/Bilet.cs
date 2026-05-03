using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_2
{
    public class Bilet: IPretCalculabil, IValidabil
    {
        public string NumeFilm { get; set; }
        public int NumarSala { get; set; }
        public TipFilm TipFilm { get; set; }
        public DateTime ExpiraLa { get; set; }
        public Client Client { get; set; }

        private int _numarLoc;
        public int NumarLoc
        {
            get { 
                return _numarLoc; 
            }

            set {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Numarul locului nu este valid.");
                }
                _numarLoc = value;
            }
        }

        private double _pretBaza;
        public double PretBaza
        {
            get
            {
                return _pretBaza;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Pretul de baza nu este valid");
                }
                _pretBaza = value;
            }
        }

        public Bilet(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza) {
            NumeFilm = numeFilm;
            NumarSala = numarSala;
            TipFilm = tipFilm;
            ExpiraLa = expiraLa;
            Client = client;
            NumarLoc = numarLoc;
            PretBaza = pretBaza;
        }

        public virtual double GetReducere() {
            return 0;
        }

        public virtual double CalculeazaPretFinal() {
            return PretBaza - GetReducere();
        }

        public virtual bool EsteValid() {
            return ExpiraLa > DateTime.Now;
        }
    }
}
