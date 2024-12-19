namespace FinalSuperHeroes.Models
{
    public class Guerrero : ISuperHeroe
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }

        public Guerrero(string nombre)
        {
            Nombre = nombre;
            Tipo = "Guerrero";
            Fuerza = 7;
            Salud = 5;
            PoderEspecial = "Ataque con cuchillo y espada";
        }

        public string Atacar() => "Apuntar y atacar al enemigo";
        public string Defender() => "Defenderse de ataques del enemigo";

    }
}
