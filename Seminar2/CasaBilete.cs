using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class CasaBilete
    {
        public List<Bilet> Bilete { get; set; } 

        public CasaBilete()
        {
            Bilete = new List<Bilet>(); 
        }

        public void AdaugaBilet(Bilet bilet) 
        {
            Bilete.Add(bilet);
        }

        public double GetIncasariTotale() 
        {
           return Bilete.Sum(bilet => bilet.CalculeazaPretFinal());
        }
        public int GetNumarBiletePerTip<T>() where T: Bilet
        {
            return Bilete.OfType<T>().Count();
        }
        public Bilet GetBiletulCelMaiScump()
        {
            return Bilete
                .OrderByDescending(bilet => bilet.CalculeazaPretFinal())
                .FirstOrDefault();
        }
    }
}
