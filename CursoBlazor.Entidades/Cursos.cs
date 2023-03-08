using System.Collections.Generic;

namespace CursoBlazor.Entidades
{
    public class Cursos
    {
        public int Id { get; set; }
        public string NombreCurso { get; set; }
        public List<Precio> ListaPrecios { get; set; }

        public Cursos()
        {

        }

        public Cursos(int id, string nombreCurso, List<Precio> listaPrecios) : this()
        {
            Id = id;
            NombreCurso = nombreCurso;
            ListaPrecios = listaPrecios;
        }

    }
}
