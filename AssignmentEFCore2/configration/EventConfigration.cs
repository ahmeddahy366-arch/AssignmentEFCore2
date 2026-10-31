using AssignmentEFCore2.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEFCore2.configration
{
    internal class EventConfigration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> e)
        {
            e.HasKey(e => e.Id);
            e.Property(e => e.Title)
              .IsRequired()
              .HasMaxLength(200);
            e.Property(e => e.Description)
              .IsRequired();
            e.Property(e => e.StartDate)
              .IsRequired();
            e.Property(e => e.EndDate)
            .IsRequired(false);
            e.Property(e=>e.MaxAttendees)
            .IsRequired();

        }
    }
}
