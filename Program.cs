using Sistema_ADM.Funcionarios;
using Sistema_ADM.Utilitario;

//Informações:
#region
//Ideia base de um sistema para permitir o cadastro de funcionários de uma empresa.
//Os dados obrigatórios são nome, cpf e telefone.
//Os dados opcionais são email e telefone.
//É possível aumentar o salario e calcular bonificações, os salarios e bonificações
//variam de cargo para cargo.
//É possível ver o total de funcionários cadastrados e o total de bonificações a
//serem pagas.
//Por fim, uma ideia a ser implementada é de uma senha que permita determinados
//funcionários a fazer alterações de informações em outros cadastros.
#endregion

Estagiario funcionario = new Estagiario("Leonardo Morato Bence", "458739528-50", 700.00);
funcionario.Email = "leobence@gmail.com";
funcionario.Telefone = "(11) 94545-5756";
funcionario.Informacoes();
funcionario.AumentarSalario();
Console.WriteLine("Bonificação do funcionario: R$" + funcionario.GetBonificacao());

Console.WriteLine("---------------------------------------------------------");

Estoquista funcionario2 = new Estoquista("Leandro Ferreira Gomez", "579267982-10", 1200.00);
funcionario2.Telefone = "(11) 2721-8895";
funcionario2.Informacoes();
funcionario2.AumentarSalario();
Console.WriteLine("Bonificação do funcionario: R$" + funcionario2.GetBonificacao());

Console.WriteLine("---------------------------------------------------------");

Comprador funcionario3 = new Comprador("Richard Silva", "956348972-70", 2000.00);
funcionario3.Informacoes();
funcionario3.AumentarSalario();
Console.WriteLine("Bonificação do funcionario: R$" + funcionario3.GetBonificacao());

Console.WriteLine("---------------------------------------------------------");

Diretor funcionario4 = new Diretor("Alberto Ferraz", "963258741-60", 4500.00);
funcionario4.Senha = "102030";
funcionario4.Informacoes();
funcionario4.AumentarSalario();
Console.WriteLine("Bonificação do funcionario: R$" + funcionario4.GetBonificacao());

Console.WriteLine("---------------------------------------------------------");

Gestor funcionario5 = new Gestor("Carlos da Fonseca", "684239715-90", 4000.00);
funcionario5.Informacoes();
funcionario5.AumentarSalario();
Console.WriteLine("Bonificação do funcionario: R$" + funcionario5.GetBonificacao());

Console.WriteLine("---------------------------------------------------------");

Tecnico funcionario6 = new Tecnico("Rogério Virgulino", "684239715-90", 2200.00);
funcionario6.Informacoes();
funcionario6.AumentarSalario();
Console.WriteLine("Bonificação do funcionario: R$" + funcionario6.GetBonificacao());

Console.WriteLine("---------------------------------------------------------");

Engenheiro funcionario7 = new Engenheiro("José Moralles", "258369147-80", 3519.00);
funcionario7.Informacoes();
funcionario7.AumentarSalario();
Console.WriteLine("Bonificação do funcionario: R$" + funcionario7.GetBonificacao());

Console.WriteLine("---------------------------------------------------------");

Operario funcionario8 = new Operario("José Roberto da Silva", "258369147-80", 1200.00);
funcionario8.Informacoes();
funcionario8.AumentarSalario();
Console.WriteLine("Bonificação do funcionario: R$" + funcionario8.GetBonificacao());

Console.WriteLine("---------------------------------------------------------");

GerenteDeContas funcionario9 = new GerenteDeContas("Roberto Moraes", "951357456-23", 2800.00);
funcionario9.Senha = "12345@";
funcionario9.Informacoes();
funcionario9.AumentarSalario();
Console.WriteLine("Bonificação do funcionario: R$" + funcionario9.GetBonificacao());

Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("Total de funcionarios cadastrados: " + Funcionario.TotalDeFuncionarios);

Console.WriteLine("---------------------------------------------------------");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(funcionario);
gerenciador.Registrar(funcionario2);
gerenciador.Registrar(funcionario3);
gerenciador.Registrar(funcionario4);
gerenciador.Registrar(funcionario5);
gerenciador.Registrar(funcionario6);
gerenciador.Registrar(funcionario7);
gerenciador.Registrar(funcionario8);
gerenciador.Registrar(funcionario9);
Console.WriteLine("Total de bonificações: R$" + gerenciador.TotalDeBonificacao);

Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("Acesso: " + funcionario4.Autenticar("102030"));