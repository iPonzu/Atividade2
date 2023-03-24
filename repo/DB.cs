using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository{

    public class DataBase : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }

        private string _connectionString = "Server=localhost;User Id=root;Database=bancoAtividadeDois";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
    }
}