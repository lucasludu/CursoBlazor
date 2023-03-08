using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBlazor.Entidades
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
        public List<Cursos> ListaCursos { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }

        public Alumno()
        {

        }

        public Alumno(int id, string nombre, string email, string foto, List<Cursos> listaCursos, DateTime fechaAlta, DateTime fechaBaja) : this()
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Foto = foto;
            ListaCursos = listaCursos;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
        }
    }
}
