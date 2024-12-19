namespace FinalSuperHeroes.Models
{
    public class Arquero : ISuperHeroe
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }

        public Arquero(string nombre)
        {
            Nombre = nombre;
            Tipo = "Arquero";
            Fuerza = 5;
            Salud = 5;
            PoderEspecial = "Disparar flechas con precisión";
        }

        public string Atacar() => "Apuntar y atacar al enemigo";
        public string Defender() => "Defenderse de ataques del enemigo";
    }
}
