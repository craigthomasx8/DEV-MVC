﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IGSDeveloperTest.Datamodel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IGSEntities : DbContext
    {
        public IGSEntities()
            : base("name=IGSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
    }
}
