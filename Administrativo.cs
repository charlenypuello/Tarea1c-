namespace ComunidadEducativa
{
    public class Administrativo : Empleado
    {
        public string Cargo { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}, Cargo: {Cargo}");
        }
    }
}
