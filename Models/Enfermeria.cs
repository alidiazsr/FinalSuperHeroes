namespace FinalSuperHeroes.Models
{
    public class Enfermeria
    {
        private static readonly Enfermeria _instancia = new Enfermeria();
        private int _atencionesRestantes = 5;
        private Enfermeria() { }
        public static Enfermeria ObtenerInstancia() => _instancia;
        public bool VisitasAEnfermeria(ref int saludActual, int cantidadVisitas)
        {
            if (_atencionesRestantes <= 0)
            {
                return false;
            }
            for (int i = 0; i < cantidadVisitas; i++)
            {
                if (_atencionesRestantes > 0 && saludActual < 5)
                {
                    saludActual++;
                    _atencionesRestantes--;
                }
            }
            return true;
        }
        public int GetVisitasRestantes() => _atencionesRestantes;
    }
}
