using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }

        [Range(1,3)]
        public int DureeJours { get; set; }

        public int LocataireKey { get; set; }
        public Locataire Locataire { get; set; }
        public Vehicule Vehicule { get; set; }
        public int VehiculeKey { get; set; }
    }
}
