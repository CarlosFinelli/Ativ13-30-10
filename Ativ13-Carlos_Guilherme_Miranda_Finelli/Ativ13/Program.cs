using System;

namespace Ativ13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o nome: ");
            String Nome = Console.ReadLine();
            Console.Write("Partido: ");
            String Partido = Console.ReadLine();
            Console.Write("Patrimônio declarado: ");
            double Patrimonio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual a atual profissão: ");
            String Profissao = Console.ReadLine();
            Console.Write("Cargo pretendido: ");
            String CargoP = Console.ReadLine();
            Console.Clear();
            Candidato candidato = new Candidato(Nome, Partido, Profissao, CargoP, Patrimonio);
            Console.WriteLine(candidato);
        }
    }
}
