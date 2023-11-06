using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Vehicule
    {
        [MaxLength(25)]
        public int VehiculeId { get; set; }
        public string Couleur { get;}

        public int Kilometrage { get; set; }
        public Double PrixJour { get; set; }

        public IList<Reservation> Reservations { get; set; }
    }
}
