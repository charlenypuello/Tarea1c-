namespace ComunidadEducativa
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
        }
    }
}
