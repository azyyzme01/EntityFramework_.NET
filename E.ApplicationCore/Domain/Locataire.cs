using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Locataire
    {
        [Required(ErrorMessage ="le champ login obligatoire")]
        public int Id { get; set; }
        public DateTime DateAdhesion { get; set; }
        public String Adresse { get; set; }

        public int PointBonus { get; set; }

        public String Telephone { get; set;}

        public Agent Agent { get; set; }

        public IList<Reservation> Reservations { get; set; }

        public virtual void LocataireType()
        {

            Console.WriteLine("I'Passenger");
        }

    }
}
