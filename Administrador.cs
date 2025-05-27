namespace ComunidadEducativa
{
    public class Administrador : Docente
    {
        public string NivelAcceso { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área: {Area}, Nivel de Acceso: {NivelAcceso}");
        }
    }
}
