using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //test puch
    //COMMIT TEST
    class Joueur
    {
        private int pointVie;
        public int _Point { get { return pointVie; } }
        public bool estVivant { get { return true; } }

        public Joueur()
        {
            pointVie = 150;
        }

        public void Attaque(string monster)
        {

        }
        public void SubitDegats(int degats)
        {

        }
    }
}
