namespace FinalSuperHeroes.Models
{
    public interface ISuperHeroe
    {

        string Nombre { get; set; }
        string Tipo { get; set; }
        int Fuerza { get; set; }
        int Salud { get; set; }
        string PoderEspecial { get; set; }

        string Atacar();
        string Defender();
    }
}
