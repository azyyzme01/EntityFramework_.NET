using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Personne : Locataire
    {
        public String Nom { get; set; }
        public String Prenom { get; set; }

        public override void LocataireType()
        {
            Console.WriteLine("iam personne");
        }

    }
}
