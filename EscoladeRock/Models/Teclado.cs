namespace EscoladeRock.Models
{
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
             System.Console.WriteLine("Mantendo ritmo do Teclado.");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Teclado.");
            return true;
        }
        
    }
}