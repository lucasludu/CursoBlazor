using CursoBlazor.Entidades;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Curso.Blazor.Shared
{
    public class ListaAlumnosBase : ComponentBase
    {
        public IEnumerable<Alumno> Alumnos { get; set; }

        protected override Task OnInitializedAsync()
        {
            CargarAlumnos();
            return base.OnInitializedAsync();
        }

        private void CargarAlumnos()
        {
            var precioBlazor = new Precio(1, 200, DateTime.Now, DateTime.Now.AddDays(3));
            var cursoBlazor = new Cursos(1, "Curso Blazor", new List<Precio>());
            cursoBlazor.ListaPrecios.Add(precioBlazor);

            var alumno1 = new Alumno(1, "Lucas", "lucas@gmail.com", "images/Alumno1.jpg", new List<Cursos>(), DateTime.Now, DateTime.MaxValue);
            var alumno2 = new Alumno(2, "Fernando", "fernando@gmail.com", "images/Alumno2.jpg", new List<Cursos>(), DateTime.Now, DateTime.MaxValue);
            var alumno3 = new Alumno(3, "Antonella", "anto@gmail.com", "images/ChicaCodigo65.jpg", new List<Cursos>(), DateTime.Now, DateTime.MaxValue);

            alumno1.ListaCursos.Add(cursoBlazor);
            alumno2.ListaCursos.Add(cursoBlazor);
            alumno3.ListaCursos.Add(cursoBlazor);

            Alumnos = new List<Alumno> { alumno1, alumno2, alumno3 };
        }
    }
}
