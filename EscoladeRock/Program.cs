using System;
using EscoladeRock.Models;
using EscoladeRock.Interfaces;

namespace EscoladeRock
{
    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };
    enum InstrumentosEnum : int {
        BAIXO,
        BETERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO
    };
    enum CategoriaEnum : int {
        HARMONIA,
        PERCUSSAO,
        MELODIA
    };
    class Program
    {
        static void Main(string[] args)
        {
          bool querSair = false;
          string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
          string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

          var opcoesForma = new List<string>()
          {
              "  - 0         ",
              "  - 1         "
          };
          int opcaoFormacao = 0;
          string menubar = "==================";
          
          do
          {
              bool formacaoEscolhida = false;

              do
              {
                  Console.Clear();
                  System.Console.WriteLine(menubar);
                  Console.BackgroundColor = Console.DarkCyan;
                  Console.ForegroundColor = ConsoleColor.Black;
                  Console.WriteLine("Seja bem-vind@");
                  System.Console.WriteLine("Escolha uma formação: ");
                  Console.ResetColor();
                  System.Console.WriteLine(menubar);

                  for(int i=0;i< opcoesFormacao.Count; i++)
                  {
                      string titulo = TratarTituloMenu(itensMenuPrincipal[i]);
                      if(opcaoFormacao == i)
                      {
                          DestacaOpcao(opcoesFormacao[opcaoFormacaoSelecionada].Replace("-",">").Replace(i.ToString));
                      }else{
                          System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(),titulo));
                      }
                      var key = Console.ReadKey(true).Key;

                      switch(key)
                      {
                          case ConsoleKey.UpArrow:
                          opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                          break;
                          
                          case ConsoleKey.DownArrow:
                          opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count -1 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                          break;
                          
                          case ConsoleKey.Enter:
                          formacaoEscolhida = true;
                          break;
                      }
                  }while (!formacaoEscolhida) :
                  bool bandaCompleta = false;
                  int vagas = 0;
                  switch(opcaoFormacaoSelecionada)
                  {
                      case 0:
                      vagas = 2;
                      do
                      {
                          ExibirMenuDeInstrumentos();
                          System.Console.WriteLine($"Digite o código do instrumento de harmonia ");
                          var instrumento = Deposito.instrumentos[codigo];
                          vagas --;
                          Type interfaceEncontrada = instrumento.GetType().GetInterface("Harmonia");
                          if
                      }
                  }
              }
          }
        } 
    }
}
