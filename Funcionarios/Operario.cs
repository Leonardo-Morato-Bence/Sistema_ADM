using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_ADM.Funcionarios
{
    public class Operario : Funcionario
    {
        public Operario(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.03;
            Console.WriteLine("Novo salario: " + this.Salario);
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.05;
        }
    }
}
