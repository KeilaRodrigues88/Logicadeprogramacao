using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula22023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" digite a idade dos alunos ");
            int idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("idade do segundo aluno");
            int idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("idade do terceiro aluno");
            int idade3 = int.Parse(Console.ReadLine());
            Console.WriteLine("idade do quarto aluno");
            int idade4 = int.Parse(Console.ReadLine());
            Console.WriteLine("idade do quinto aluno");
            int idade5 = int.Parse(Console.ReadLine());
            int idadeMedia = (idade1 + idade2 + idade3 + idade4 + idade5)/5;
            Console.WriteLine(idadeMedia);

            Console.ReadLine();
        }
    }
}
