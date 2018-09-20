using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Animal
    {
        Action<string> affiche = Console.WriteLine;
        public int NombreDePattes { get; set; }
        protected bool estVivant;
        protected string prenom = "marcel";
        public int age;

        public override bool Equals(object obj)
        {
            Animal A = obj as Animal;
            if (A == null)
                return false;
            return age == A.age;
            //return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return age.GetHashCode();
        }
        public void Respirer()
        {
           affiche("Je suis " + prenom + " et je respire");
        }
    }
    interface IAnimal{
        //par défaut tous le membre sont public donc pas besoins de définir public ou private
        //dans une interface on implement pas les méthodes 
        //une classe peut implémenter plusieures interface car le c# n'accepte pas l'héritage multiple
}
    class Chien : Animal
    {
        //public Chien(string prenomDeChien)
        //{
        //    //prenom = prenomDeChien;
        //}
        public void aboyer()
        {
            Console.WriteLine("waouf!");

        }
        public void Vieillir()
        {
            age++;
        }
        public void Naissance()
        {
            age = 0;
            estVivant = true;
        }
    }

    class Chat:Animal
    {
        public Chat(string prenomChat)
        {
            prenom = prenomChat;
        }
        public void Miauler()
        {
            Console.WriteLine("Miaou");
        }
    }

}
