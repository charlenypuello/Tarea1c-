namespace ComunidadEducativa
{
    public class Maestro : Docente
    {
        public string Materia { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área: {Area}, Materia: {Materia}");
        }
    }
}
