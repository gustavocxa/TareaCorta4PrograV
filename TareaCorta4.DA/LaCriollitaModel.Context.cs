﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TareaCorta4.DA
{
    using Newtonsoft.Json;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LaCriollitaEntities : DbContext
    {
        public LaCriollitaEntities()
            : base("name=LaCriollitaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        [JsonIgnore]
        public virtual DbSet<Categorias> Categorias { get; set; }
        [JsonIgnore]
        public virtual DbSet<Estados> Estados { get; set; }
        [JsonIgnore]
        public virtual DbSet<Platillos> Platillos { get; set; }
        [JsonIgnore]
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}