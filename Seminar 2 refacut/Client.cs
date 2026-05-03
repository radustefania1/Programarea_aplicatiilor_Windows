using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_2
{
    public class Client
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }


        private string _email;
        public string Email {
            get {
                return _email;
            }

            set {
                if (value == null || !value.Contains("@") || !value.Contains(".")) {
                    throw new ArgumentException("Email-ul nu este valid.");
                }
                _email = value;
            }
        }


        private string _telefon;
        public string Telefon
        {
            get {
                return _telefon;
            }

            set {
                if (value == null || value.Length != 10) {
                    throw new ArgumentException("Numarul de telefon nu este valid");
                }
                _telefon = value;
            }
        }


        public Client(string nume, string prenume, string telefon, string email)
        {
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            Email = email;
        }
    }
}
