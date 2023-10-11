﻿using DesignLibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryContext : DbContext
    {
        private readonly string _connectionString;

        public LibraryContext(string connectionString)
        {
            _connectionString = connectionString;

        }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }


        public virtual DbSet<TransactionEntity> LibraryTransaction { get; set; }

        public virtual DbSet<LibraryMemberEntity> LibraryMember { get; set; }

        public virtual DbSet<BookEntity> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { optionsBuilder.UseSqlServer(_connectionString); }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BookEntity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int");
                entity.Property(e => e.Title).HasColumnType("nvarchar(50)");
                entity.Property(e => e.Author).HasColumnType("nvarchar(50)");
                entity.Property(e => e.ISBN).HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<LibraryMemberEntity>(entity =>
            {
                entity.HasKey(e => e.MemberID);
                entity.Property(e => e.MemberID).HasColumnType("int");
                entity.Property(e => e.Name).HasColumnType("nvarchar(50)");
                entity.Ignore(e => e.BooksBorrowed);
            });

            modelBuilder.Entity<TransactionEntity>(entity =>
            {
                entity.HasKey(e => e.TransactionID);
                entity.Property(e => e.TransactionID).HasColumnType("int");
                entity.Property(e => e.DueDate).HasColumnType("DateTime");

                //entity.HasOne(d => d.BookID).WithMany(e => e.LibraryTransaction)
                //.HasForeignKey(e => e.BookID)
                //.OnDelete(DeleteBehavior.Cascade);
            });
        }

    }
}