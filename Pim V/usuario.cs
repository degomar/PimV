using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Task;

namespace Cadastro
{
	class Usuario {
		private const string V = "Senha: ";

		static void Main(string[] args)
		{
			string nome;
			string Disciplina;
			int Telefone;
			int Senha;
			int SenhaConf;
			string Id = "Demo01";

	//---------------------------------------------------------------------------
			
			//campo de digitar nome
			Console.WriteLine("Digite o seu nome: ");
			nome = Console.ReadLine();
			//Console.WriteLine(nome);

			//campo disciplina
			Console.WriteLine("Digite a disciplina: ");
			Disciplina = Console.ReadLine();
			//Console.WriteLine(Disciplina);

			//campo telefone
			Console.WriteLine("Digite seu telefone");
			Telefone = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine(Disciplina);


			ValidSenha:
			//campo cadastrar senha
			Console.WriteLine("Digite uma senha numerica");
			Senha = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine(Senha);

			//campo conferencia de senha
			Console.WriteLine("Confirme a sua senha numerica");
			SenhaConf = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine(SenhaConf);

			//valdação dos campos
			if (Senha == SenhaConf)
			{
				Console.WriteLine("Cadastro realizado com sucesso, seu ID de professor é " + Id, 
					"\nDados gravados: \n \nNome: " + nome, 
					"Disciplina: \n" + Disciplina, 
					"Telefone para contato: \n" + Telefone,
					V + Senha);
				return;
			}
			else
				Console.WriteLine("Senha Incorreta. Favor digite novamente a sua senha");
			goto ValidSenha;
		}
	}
}
