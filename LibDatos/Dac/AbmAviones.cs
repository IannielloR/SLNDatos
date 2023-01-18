using LibDatos.Data;
using LibDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LibDatos.Dac
{
    public class AbmAviones
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();
        public static List<Avion> SelectAll()
        {
            return context.Aviones.ToList();
        }


        public static int Insert(Avion avion)
        {
            context.Aviones.Add(avion);
            return context.SaveChanges();
        }

        public static Avion SelectWhereById(int id)
        {
            return context.Aviones.Find(id);
        }

        public static int Update(Avion avion)
        {
            Avion avionOrigen = context.Aviones.Find(avion.AvionId);
            if (avionOrigen != null)
            {
                avionOrigen.Denominacion = avion.Denominacion;
                avionOrigen.Capacidad = avion.Capacidad;
            }

            return context.SaveChanges();
        }

        public static int Delete(Avion alumno)
        {
            Avion avionOrigen = context.Aviones.Find(alumno.AvionId);
            if (avionOrigen != null)
            {
                context.Aviones.Remove(avionOrigen);
                return context.SaveChanges();
            }
            return 0;
        }

    }     
}
