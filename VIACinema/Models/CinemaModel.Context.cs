﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VIACinema.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CinemaContext : DbContext
    {
        public CinemaContext()
            : base("name=CinemaContext")
        {
            Seats = Set<Seat>();
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Stage> Stages { get; set; }
        internal virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<MovieSession> MovieSessions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}
