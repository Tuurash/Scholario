﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scholar.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class scholarDBContext : DbContext
    {
        public scholarDBContext()
            : base("name=scholarDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<courseTB> courseTBs { get; set; }
        public virtual DbSet<instructorTB> instructorTBs { get; set; }
        public virtual DbSet<userTB> userTBs { get; set; }
        public virtual DbSet<adminTB> adminTBs { get; set; }
    }
}
