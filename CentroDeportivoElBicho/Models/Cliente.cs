using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace CentroDeportivoElBicho.Models
{
    public class Cliente
    {
        [Key]
        public int? idCliente { get; set; }
        public string? nombreCliente { get; set; }
        public string? correoCliente { get; set; }
        public string? telefonoCliente { get; set; }
        public string? nacimientoCliente { get; set; }

        public string? direccionCliente { get; set; }

        public string? passwordCliente { get; set; }

        public int? rolCliente { get; set; }

    }
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente>? Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;database=testcanchas;user=root;password=");
        }
    }
}
