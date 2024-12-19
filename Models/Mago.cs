namespace FinalSuperHeroes.Models
{
    public class Mago : ISuperHeroe
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }
        public Mago(string nombre)
        {
            Nombre = nombre;
            Tipo = "Mago";
            Fuerza = 3;
            Salud = 5;
            PoderEspecial = "Usar Magia Encantada";
        }

        public string Atacar() => "Apuntar y atacar al enemigo";
        public string Defender() => "Defenderse de ataques del enemigo";
    }
}
