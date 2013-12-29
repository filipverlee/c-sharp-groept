using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Practicum15
{
    class Batterijverpakking
    {
        public List<Batterij> Voorraad { get; private set; }

        public Batterijverpakking()
        {
            Voorraad = new List<Batterij>();
        }

        public void BatterijToevoegen(Batterij b)
        {
            Voorraad.Add(b);
        }
    }
}
