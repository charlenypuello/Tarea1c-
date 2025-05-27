namespace ComunidadEducativa
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoGraduacion { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
        }
    }
}
