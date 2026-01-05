using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_SandwichMaker
{
    internal class Sandwich
    {
        //Attributs
        private string[] _proteine = {"jambon", "fromage", "Poulet", "Dinde"};
        private string[] _condiment = { "Mayo", "ketchup", "moutarde", "samourai" };
        private string[] _pain = { "complet", "multi céréale", "gris", "blanc" };
        private string[] _crudite = { "salade", "tomate", "oignon", "cornichn" };

        //Props


        //Construct



        //Méthodes
        public string ComposeSandwich()
        {
            Random rnd = new Random();
            string randomProteine = _proteine[rnd.Next(_proteine.Length)];
            string randomCondiment = _condiment[rnd.Next(_proteine.Length)];
            string randomPain = _pain[rnd.Next(_proteine.Length)];
            string randomCrudite = _crudite[rnd.Next(_proteine.Length)];

            return $"Pain {randomPain}, Viande {randomProteine}, Condiment {randomCondiment}, Crudite {randomCrudite}";
        }
    }
}
