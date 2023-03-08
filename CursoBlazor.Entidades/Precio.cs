using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBlazor.Entidades
{
    public class Precio
    {
        public int Id { get; set; }
        public double Importe { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Precio()
        {

        }

        public Precio(int id, double importe, DateTime fechaInicio, DateTime fechaFin)
        {
            Id = id;
            Importe = importe;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

    }
}
