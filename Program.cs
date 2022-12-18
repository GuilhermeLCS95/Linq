using System.Linq;
using System.IO;
using System.Collections.Generic;
using ExercícioLinq.Entities;
using System.Globalization;
namespace ExercícioLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o diretório do arquivo CSV: ");
            string diretorio = Console.ReadLine();
            List<Funcionários> funcionários = new List<Funcionários>();
            using (StreamReader sr = File.OpenText(diretorio))
            {
                while (!sr.EndOfStream)
                {
                    string[] func = sr.ReadLine().Split(',');
                    string name = func[0];
                    string email = func[1];
                    double salário = double.Parse(func[2], CultureInfo.InvariantCulture);
                    funcionários.Add(new Funcionários(name, email, salário));
                }
            }
            Console.Write("Entre com um valor de salário: ");
            double filtrosalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var func1 = funcionários.Where(x => x.Salário > filtrosalario).OrderBy(x => x.Email).Select(x => x.Email);
            var func2 = funcionários.Where(x => x.Nome[0] == 'M').Sum(x => x.Salário);
            foreach (string func in func1)
            {
                Console.WriteLine(func);
            }
            Console.WriteLine();
            Console.WriteLine("Soma dos nomes de quem começa com M: " + func2);
            
        }
    }
}