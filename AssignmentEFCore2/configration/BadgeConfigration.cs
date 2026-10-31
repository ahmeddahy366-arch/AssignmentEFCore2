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
    public class BadgeConfigration : IEntityTypeConfiguration<Badge>
    {
        void IEntityTypeConfiguration<Badge>.Configure(EntityTypeBuilder<Badge> b)
        {
            b.HasKey(b => b.Id);
            b.Property(b => b.BadgeNumber)
             .IsRequired(true);
            b.Property(b => b.IssueDate);
            b.HasOne(b => b.attendee)
             .WithOne(a => a.badge)
             .HasForeignKey<Badge>(b => b.attendeeid);
        }
    }
}
