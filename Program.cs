using System;
using System.Collections.Generic;

namespace ComunidadEducativa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>
            {
                new Estudiante { Nombre = "Luis", Edad = 20, Carrera = "Ingeniería" },
                new ExAlumno { Nombre = "Ana", Edad = 30, AñoGraduacion = 2015 },
                new Administrativo { Nombre = "Carlos", Edad = 40, Departamento = "Finanzas", Cargo = "Contador" },
                new Administrador { Nombre = "Laura", Edad = 45, Departamento = "Académico", Area = "Dirección", NivelAcceso = "Alto" },
                new Maestro { Nombre = "José", Edad = 38, Departamento = "Ciencias", Area = "Matemáticas", Materia = "Álgebra" }
            };

            foreach (var miembro in miembros)
            {
                miembro.MostrarInformacion();
                Console.WriteLine("--------------------------");
            }
        }
    }
}
