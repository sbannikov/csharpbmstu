﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bmstu.IU6.Core
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccessRoles> AccessRoles { get; set; }
        public virtual DbSet<AccidentClasses> AccidentClasses { get; set; }
        public virtual DbSet<Accidents> Accidents { get; set; }
        public virtual DbSet<ButtonEvents> ButtonEvents { get; set; }
        public virtual DbSet<Buttons> Buttons { get; set; }
        public virtual DbSet<ButtonSnapshots> ButtonSnapshots { get; set; }
        public virtual DbSet<CommandMessages> CommandMessages { get; set; }
        public virtual DbSet<ConveyorEvents> ConveyorEvents { get; set; }
        public virtual DbSet<ConveyorMatrices> ConveyorMatrices { get; set; }
        public virtual DbSet<Cycles> Cycles { get; set; }
        public virtual DbSet<MediaPlayers> MediaPlayers { get; set; }
        public virtual DbSet<MediaPlayerStatus> MediaPlayerStatus { get; set; }
        public virtual DbSet<Plans> Plans { get; set; }
        public virtual DbSet<PostSnapshots> PostSnapshots { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<UdpVariables> UdpVariables { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
