﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookLibrary.Models
{
    public partial class CCENTENNIALCOLLEGE2021WINTERLABSLAB5BOOKSMDFContext : DbContext
    {
        public CCENTENNIALCOLLEGE2021WINTERLABSLAB5BOOKSMDFContext()
        {
        }

        public CCENTENNIALCOLLEGE2021WINTERLABSLAB5BOOKSMDFContext(DbContextOptions<CCENTENNIALCOLLEGE2021WINTERLABSLAB5BOOKSMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthorIsbn> AuthorIsbn { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Titles> Titles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; database=C:\\CENTENNIALCOLLEGE\\2021WINTER\\LABS\\LAB#5\\BOOKS.MDF;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorIsbn>(entity =>
            {
                entity.HasKey(e => new { e.AuthorId, e.Isbn });

                entity.ToTable("AuthorISBN");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.AuthorIsbn)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorISBN_Authors");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.AuthorIsbn)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorISBN_Titles");
            });

            modelBuilder.Entity<Authors>(entity =>
            {
                entity.HasKey(e => e.AuthorId);

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Titles>(entity =>
            {
                entity.HasKey(e => e.Isbn);

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Copyright)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
