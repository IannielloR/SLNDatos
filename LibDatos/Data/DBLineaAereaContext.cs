using LibDatos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LibDatos.Data
{
    public class DBLineaAereaContext : DbContext
    {
        //Constructor
        public DBLineaAereaContext() : base("KeyDB") { }

        //Propiedades DBSET
        public DbSet<LineaAerea> LineasAereas { get; set; }
        public DbSet<Avion> Aviones { get; set; }
    }
}
