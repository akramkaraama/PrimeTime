﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WPG_ConferenceEntities : DbContext
    {
        public WPG_ConferenceEntities()
            : base("name=WPG_ConferenceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Guest> Employee_Guest { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<Meeting_Employee> Meeting_Employee { get; set; }
        public virtual DbSet<MeetingStatu> MeetingStatus { get; set; }
        public virtual DbSet<MeetingType> MeetingTypes { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    }
}