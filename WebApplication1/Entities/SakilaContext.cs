using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Entities;

public partial class SakilaContext : DbContext
{

    public SakilaContext(DbContextOptions<SakilaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Language> Languages { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=a1234;database=sakila");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.language_id).HasName("PRIMARY");

            entity.ToTable("language");

            entity.Property(e => e.language_id)
                .ValueGeneratedOnAdd()
                .HasColumnName("language_id");
            entity.Property(e => e.last_update)
                .HasColumnType("string")
                .HasColumnName("last_update");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("name");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
