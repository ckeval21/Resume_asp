﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using VRT.Resume.Domain.Entities;
using VRT.Resume.Persistence.Data;

namespace VRT.Resume.Persistence.Data.Configurations
{
    public partial class PersonSkillConfiguration : IEntityTypeConfiguration<PersonSkill>
    {
        public void Configure(EntityTypeBuilder<PersonSkill> entity)
        {
            entity.HasKey(e => e.SkillId).HasName("PK_PersonSkill_1");

            entity.ToTable("PersonSkill", "Persons", tb => tb.HasComment("Table contains full list of person skills"));

            entity.HasIndex(e => e.PersonId, "IX_PersonSkill_PersonId");

            entity.HasIndex(e => e.SkillTypeId, "IX_PersonSkill_SkillTypeId");

            entity.Property(e => e.Level)
            .IsRequired()
            .HasMaxLength(50)
            .HasComment("Knowledge level of the skill");
            entity.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50)
            .HasComment("Default name of the skill");
            entity.Property(e => e.SkillTypeId).HasComment("Skill type id");

            entity.HasOne(d => d.Person).WithMany(p => p.PersonSkill)
            .HasForeignKey(d => d.PersonId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PersonSkill_Person");

            entity.HasOne(d => d.SkillType).WithMany(p => p.PersonSkill)
            .HasForeignKey(d => d.SkillTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PersonSkill_SkillType");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PersonSkill> entity);
    }
}