
namespace cadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(@$"
=============================================================
|            BEM-VINDO AO SISTEMA DE CADASTRO               |
|            DE PESSOAS FÍSICA E JURIDICA                   |
=============================================================


");
            BarraCarregamento("Iniciando");
            
            string opcao;           
            do
            {
                Console.WriteLine(@$"
=============================================================
|                   1 - PESSOA FÍSICA                       |
|                   2 - PESSOA JURIDICA                     |
|                                                           |
|                   0 - SAIR                                |
=============================================================
");
                opcao = Console.ReadLine();
            
                switch (opcao)
                {
                    case opcao == "1":
                    PessoaFisica pf = new PessoaFisica();
                    PessoaFisica novaPf = new PessoaFisica();
                    Endereco end = new Endereco();
                    end.logradouro = "Rua Guanabara";
                    end.numero = 300;
                    end.complemento = "Próximo a sorveteria";
                    end.enderecoComercial = false;

                    novaPf.endereco = end;
                    novaPf.cpf = "123456789";
                    novaPf.nome = "Jean Carlos";
                    novaPf.dataNascimento = new DateTime(1998,07,13);

                    Console.WriteLine(@$"Rua: {end.logradouro},{end.numero}");

                    bool idadeValida = pf.ValidarDataNascimento(novaPf.dataNascimento);

                    if (idadeValida)
                    {
                        Console.WriteLine($"Cadastro Aprovado");

                    }else{
                        Console.WriteLine($"Cadastro Reprovado");
                    }
                        break;
                    case opcao == "2":
                    PessoaJurica pj = new PessoaJurica();
                    PessoaJurica novaPj = new PessoaJurica();

                    Endereco endPj = new Endereco();
                    endPj.logradouro = "Rua X";
                    endPj.numero = 100;
                    endPj.complemento = "Complemento PJ";
                    endPj.enderecoComercial = true;

                    novaPj.endereco = endPj;
                    novaPj.cnpj = "12345678900001";
                    novaPj.razaoSocial = "Pessoa Juridica";



                    if (pj.ValidarCNPJ(novaPj.cnpj))
                    {
                        Console.WriteLine($"CNPJ VÁLIDO");

                    }
                    else
                    {
                        Console.WriteLine($"CNPJ INVÁLIDO");
                    }
                        break;
                    case opcao == "0":
                        Console.WriteLine($"Obrigado por usar nosso sistema!");
                        BarraCarregamento("Finalizando");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida, digite uma opção válida");
                        break;
                }
                
            } while (opcao != "0");
            
            

            
        }
        static void BarraCarregamento(string textoCarregamento){
            Console.ResetColor();
            Console.ForegroundColor = Conseole.DarkRed;
            Console.Write(textoCarregamento);
            Thread.Sleep(500);

            for (var i = 0; i < 10; i++)
            {
                Console.Write("_");
                Thread.Sleep(500);
            }
        }
    }
}
