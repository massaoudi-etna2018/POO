using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POO.Animal;

namespace POO//ce positionner sur mon application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action <string> affiche = Console.WriteLine;
            ////déclaration d'un objet vide les instances de notre objet Voiture
            //Voiture peugeot = new Voiture();//initialiser l'objet, on a crée une référence vers l'objet(une sorte de pointeur qui nous reserve une espace dans la memoire)
            ////le passage par valeur contient le vrai valeur
            ////le passage par référence nous donne l'emplacement
            //peugeot.Klaxoner();//au moment de l'initiation de l'objet le vitesse est 5 km/h

            ////déclaration des propriétes
            //peugeot.color = "rouge";
            //peugeot.numeserie = 0660;

            //peugeot.vitesse = 70;
            //peugeot.Klaxoner();

            ////Animal animal = new Animal { NombreDePattes = 4 };
            ////animal.Respirer();
            ////Console.WriteLine();

            ////Chien chien = new Chien { NombreDePattes = 4 };
            ////animal.Respirer();
            ////Console.WriteLine();

            //List<Animal> animaux = new List<Animal>();           
            //Animal chien = new Chien();
            //Animal felix = new Chat("felix");
            //Animal Brad = new Chat("Brad");
            //Animal maillon = new Chat("maillon");
            //animaux.Add(chien);
            //animaux.Add(felix);
            //animaux.Add(Brad);
            //animaux.Add(maillon);

            //foreach(Animal animal in animaux)
            //{
            //    animal.Respirer();
            //}
            
           
        }
    }
}
//L’encapsulation protège les données de l’objet et son fonctionnement interne

//héritage:un objet ne peut hériter que d'un seul objet
//polymorphisme: la capacité d'un objet de faire le mem action avec plusiers intervenant
//une classe est une manière de représenter un objet
//la comparaison des références des objets se fait par la méthode equals
//hashcode pour donner un identifiant au propriété de notre objet(avec equals)