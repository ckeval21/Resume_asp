﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using VRT.Resume.Domain.Entities;
using VRT.Resume.Persistence.Data;

namespace VRT.Resume.Persistence.Data.Configurations
{
    public partial class DegreeConfiguration : IEntityTypeConfiguration<Degree>
    {
        public void Configure(EntityTypeBuilder<Degree> entity)
        {
            entity.ToTable("Degree", "Persons", tb => tb.HasComment("Dictionary table with available degrees"));

            entity.Property(e => e.Abreviation).HasMaxLength(10);
            entity.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Degree> entity);
    }
}