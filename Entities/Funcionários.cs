using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioLinq.Entities
{
    internal class Funcionários
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salário { get; set; }

        public Funcionários(string nome, string email, double salário)
        {
            Nome = nome;
            Email = email;
            Salário = salário;
        }
    }
}
