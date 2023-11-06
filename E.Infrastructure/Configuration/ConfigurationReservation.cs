using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E.ApplicationCore.Domain;

namespace E.Infrastructure.Configuration
{
    public class ReservationConfig : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(p => new
            {
                p.LocataireKey,
                p.VehiculeKey,
                p.DateReservation
            });
        }
    }
}
