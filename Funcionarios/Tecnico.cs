using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_ADM.Funcionarios
{
    public class Tecnico : Funcionario
    {
        public Tecnico(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.07;
            Console.WriteLine("Novo salario: " + this.Salario);
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
