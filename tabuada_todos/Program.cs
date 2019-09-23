using System;

namespace tabuada_todos
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i <=10; i++){
                for(int j=1; j <=10;j++){
                    Console.Write($"{j} * {i} = {j*i} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
