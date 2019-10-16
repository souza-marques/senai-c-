using System;
using EscoladeRock.Interfaces;
namespace EscoladeRock.Models


{
    public class Violao : InstrumentoMusical, IMelodia, IHarmonia, IPercussao
    {

    public bool TocarAcordes()
    {
        System.Console.WriteLine("Mantendo o ritmo do violão");
        return true;
    }
    }
}