using System;
namespace SENAIzinho
{
    public class Aluno
    {
        public string Nome;
        public DateTime DataNascimento;
        public string Curso;
        public int NumeroSala;

        public Aluno (string Nome, DateTime DataNascimento,string Curso, int Numerosala)
        {
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Curso = Curso;
            this.NumeroSala = Numerosala;
        }
       
    }
}