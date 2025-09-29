using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Premier_Poo
{
    internal class Chien
    {
        //Attribut
        private string _nom;
        private int _age;
        private string _race;

        //Constructeur
        public Chien(string nom, int age, string race)
        {
            _nom = nom;
            _age = age;
            _race = race;
        }

        //Méthode
        public string Affichercaracteristique()
        {
            return $"Nom : {_nom} - Age : {_age} - Race : {_race}";
        }

        public void Aliment(out string aliments)
        {
            Console.WriteLine("Que voulez vous donner à manger à votre chien ?");
            aliments = Console.ReadLine();
        }
        public string Manger(string aliments)
        {
            string info = $"{_nom} à manger {aliments} ";
            return info;
        }

        public string Aboyer()
        {
            string info = "WOUAF WOUAF !";
            return info;
        }

        public void veillir()
        {
            _age += 1;
        }

    }

}
