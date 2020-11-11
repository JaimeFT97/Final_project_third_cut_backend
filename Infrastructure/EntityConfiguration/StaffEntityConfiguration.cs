﻿using Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Infrastructure.EntityConfiguration
{
    public class StaffEntityConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> StaffConfiguration)
        {
            StaffConfiguration.HasKey(s => s.Id);
            StaffConfiguration.Property(s => s.Name)
                .HasMaxLength(30)
                .IsRequired(true);
            StaffConfiguration.Property(s => s.Age)
                .HasMaxLength(30)
                .IsRequired(true);
            StaffConfiguration.Property(s => s.Gender)
                .HasMaxLength(30)
                .IsRequired(true);
            StaffConfiguration.Property(s => s.Role)
                .HasMaxLength(30)
                .IsRequired(true);
        }
    }
}
