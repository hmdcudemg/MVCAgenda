using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVC4_Agenda.Models
{
    public class Contacto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Puesto { get; set; }
        public string Organizacion { get; set; }
        public string MostrarComo { get; set; }
        public string PaginaWeb { get; set; }
        public string DireccionTM { get; set; }

    }
    public class ContactoDBContext : DbContext
    {
        public DbSet<Contacto> Contactos { set; get; }
    }
}