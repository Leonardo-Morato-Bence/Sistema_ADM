using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        
        public static int TotalDeFuncionarios { get; private set; }
        public abstract double GetBonificacao();
        public abstract void AumentarSalario();

        public void Informacoes()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("CPF: " + this.Cpf);
            Console.WriteLine("Salario: " + this.Salario);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Telefone: " + this.Telefone);
        }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }
    }
}
