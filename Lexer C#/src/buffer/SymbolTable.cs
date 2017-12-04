using System;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace buffer
{
	/// 
	/// <summary>
	/// @author Usuario
	/// </summary>
	public class SymbolTable
	{


		internal string descricao;
		internal string nome_token;


		public static Tokens Valores(int tipo)
		{
			Tokens aux = new Tokens("Nulo","Nulo"," - ");
				if (tipo == 251)
				{
					aux.Descricao = "fim da linha";
					aux.Nome_token = "<EOL>";



				}
			else if (tipo == 252)
			{
					aux.Descricao = "atribuicao";
					aux.Nome_token = "<EQUALS>";

			}

			else if (tipo == 253)
			{
					aux.Descricao = "palavra chave";
					aux.Nome_token = "<INSERT>";

			}
			else if (tipo == 254)
			{
					aux.Descricao = "inicio de expressão";
					aux.Nome_token = "<OPEN>";

			}
			else if (tipo == 255)
			{
					aux.Descricao = "fim de expressão";
					aux.Nome_token = "<CLOSE>";

			}
			else if (tipo == 256)
			{
					aux.Descricao = "palavra chave";
					aux.Nome_token = "<WHERE>";

			}
			else if (tipo == 257)
			{
					aux.Descricao = "palavra chave";
					aux.Nome_token = "<UPDATE>";

			}
			else if (tipo == 258)
			{
					aux.Descricao = "palavra chave";
				   aux.Nome_token = "<INTO>";

			}
			else if (tipo == 259)
			{
					aux.Descricao = "palavra chave";
					aux.Nome_token = "<SET>";

			}
			else if (tipo == 260)
			{
					aux.Descricao = "palavra chave";
					aux.Nome_token = "<VALUES>";

			}
			else if (tipo == 261)
			{
					aux.Descricao = "conjunto de caracteres";
					aux.Nome_token = "<STRING>";

			}
			else if (tipo == 262)
			{
					aux.Descricao = "valor numerio";
					aux.Nome_token = "<NUM>";

			}
			else if (tipo == 263)
			{
					aux.Descricao = "variavel";
					aux.Nome_token = "<ID>";

			}
			else if (tipo == 264)
			{
					aux.Descricao = "mais";
					aux.Nome_token = "<PLUS>";

			}
			else if (tipo == 265)
			{
					aux.Descricao = "separação de atributos";
					aux.Nome_token = "<COMMA>";

			}
			else
			{
				Console.WriteLine("Tipo de simbolo não presente na tabela");
				aux.Descricao = "Simbolo não presente";
				aux.Nome_token = "Nulo";
			}

		return aux;

		}
	}

}