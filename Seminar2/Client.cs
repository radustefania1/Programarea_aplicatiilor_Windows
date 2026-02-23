using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class Client
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        private string _email;   //am pus_ca sa stiu ca e un camp la nivelul clasei si e privat
        public string Email 
        {
            get { return _email; }
            set 
            {
                if (value.Contains('@') && value.Contains('.'))
                    _email = value;
                else
                    throw new ArgumentException("Adresa de email nu este valida");
            }
        }

        private string _telefon;
        public string Telefon
        {
            get { return _telefon; }
            set
            {
                if (value.Length != 10)
                    throw new ArgumentException("Numarul de telefon nu e valid");
                else
                    _telefon = value;
            }
        }

        public Client(string nume, string prenume, string email, string telefon)
        {
            Nume = nume; 
            Prenume = prenume; 
            Email = email; 
            Telefon = telefon;
        }
    }
}
