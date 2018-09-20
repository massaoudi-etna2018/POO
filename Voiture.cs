using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Voiture
    {
        public int vitesse { get; set; }
        public string color { get; set; }
        public int numeserie { get; set; }

        //création des méthode dans notre class accessible partout
        //Private: methode accessible qu'à partir de la classe à laquelle elle est définie
        //protected: methode accessible  à partir de la classe et son classe dérivé

        //methode d'extension linQ

        //constructeur: methode particulière qui porte le mem nom de la classe, pas de type de retour et on l'appel par new

        //initialiser ou charger des valeurs
        public Voiture()
        {
             this.numeserie = 2322;
             this.vitesse = 5;
        }
        public void Klaxoner()
        {
            //appeler une methode dans une autre 
            if(!vitesseAutorisee(180))
            Console.WriteLine("pouet !");
            Console.WriteLine("je roule a " +this.vitesse + "km/h");
        }
        public bool vitesseAutorisee(int vitesse)
        {
            //if (vitesse > 90)
            //    return false;
            //else
            //    return true;
            //bool estVitesseAutorisee = vitesse <= 90;
            //return estVitesseAutorisee;
            return vitesse <= 90;

        }
    }
}
