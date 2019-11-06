using Zoologico.Interfaces;
namespace Zoologico.Models.Animais
{
    public class Pinguim : Animal, IQuinofilo
    {
        public string ResistirAoFrio()
        {
            return this.GetType().Name + " consegue aguentar um frio brabo!";
        }
    }
}