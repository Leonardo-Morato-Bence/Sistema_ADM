using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_ADM.Funcionarios
{
    public class Estagiario : Funcionario
    {
        public Estagiario(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.00;
            Console.WriteLine("Novo salario: " + this.Salario);
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.0;
        }
    }
}
