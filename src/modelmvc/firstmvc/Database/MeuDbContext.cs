using System;
using firstmvc.Models;
using Microsoft.EntityFrameworkCore;

namespace firstmvc.Database
{
	public class MeuDbContext : DbContext
	{
        private readonly IConfiguration _configuration;

        public MeuDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);

            options.UseSqlServer(
                _configuration.GetConnectionString("FistMvcApp")
            );
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}

