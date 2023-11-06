using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Entreprise : Locataire
    {
        public String Intitule { get; set; }


        public override void LocataireType()
        {
            Console.WriteLine("iam Entreprise");
        }
    }


}
