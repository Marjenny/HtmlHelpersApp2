using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HtmlHelpersApp2.Models
{
    public class Cliente

    {
        [Required]
        [Key]
        public int ClienteId { get; set; }
        [Required]
        public int Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Range(15,99, ErrorMessage ="Error, Tiene que ser mayor de 15" )]
        public int Edad { get; set; }
        [Phone]
        public string Telefono { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name ="Genero")]
        public Genero  Cliente_Genero  { get; set; }
        [Display(Name = "Estado civil")]
        public string Estado_civil { get; set; }
        public bool Leer { get; set; }
        public bool Cantar { get; set; }
        public bool Bailar { get; set; }
        public bool Escribir { get; set; }
    }
    public enum Genero
    {
        Masculino,
        Femenino
    }

     public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options): base(options)
        {

        }
            public DbSet<Cliente> Clientes { get; set; }
    }

}
