using System;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace buffer
{
//JAVA TO C# CONVERTER TODO TASK: This Java 'import static' statement cannot be converted to C#:
//	import static javafx.scene.input.KeyCode.E;
//JAVA TO C# CONVERTER TODO TASK: This Java 'import static' statement cannot be converted to C#:
//	import static javafx.scene.input.KeyCode.T;
	/// 
	/// <summary>
	/// @author Usuario
	/// </summary>
	public class Lexer
	{
		 internal virtual Tokens analise(string palavra)
		 {
			Tokens token = null;


			if (palavra.Equals(";"))
			{
				token = SymbolTable.Valores(251);
				token.valor = " - ";
			}


			else if (palavra.Equals("="))
			{
				token = SymbolTable.Valores(252);
				token.valor = " - ";
			}


			else if (palavra.Equals("INSERT", StringComparison.CurrentCultureIgnoreCase))
			{
				token = SymbolTable.Valores(253);
				token.valor = " - ";
			}


			else if (palavra.Equals("("))
			{
				token = SymbolTable.Valores(254);
				token.valor = " - ";
			}


			else if (palavra.Equals(")"))
			{
				token = SymbolTable.Valores(255);
				token.valor = " - ";
			}


			else if (palavra.Equals("WHERE", StringComparison.CurrentCultureIgnoreCase))
			{
				token = SymbolTable.Valores(256);
				token.valor = " - ";
			}


			else if (palavra.Equals("UPDATE", StringComparison.CurrentCultureIgnoreCase))
			{
				token = SymbolTable.Valores(257);
				token.valor = " - ";
			}

			else if (palavra.Equals("INTO", StringComparison.CurrentCultureIgnoreCase))
			{
				token = SymbolTable.Valores(258);
				token.valor = " - ";
			}


			else if (palavra.Equals("SET", StringComparison.CurrentCultureIgnoreCase))
			{
				token = SymbolTable.Valores(259);
				token.valor = " - ";
			}

			else if (palavra.Equals("VALUES", StringComparison.CurrentCultureIgnoreCase))
			{
				token = SymbolTable.Valores(260);
				token.valor = " - ";
			}


			else if (palavra.matches("^'{1}.*'$"))
			{
				token = SymbolTable.Valores(261);
				token.valor = palavra;
			}


			else if (palavra.matches("[+,-]?[0-9]+([\\.][0-9]+)?"))
			{
				token = SymbolTable.Valores(262);
				token.valor = palavra;
			}
			else if (palavra.matches("[a-zA-Z]+\\w*"))
			{
				token = SymbolTable.Valores(263);
				token.valor = palavra;
			}
			else if (palavra.Equals("+", StringComparison.CurrentCultureIgnoreCase))
			{
				token = SymbolTable.Valores(264);
				token.valor = " - ";
			}

			else if (palavra.Equals(","))
			{
				token = SymbolTable.Valores(265);
				token.valor = " - ";
			}
			else
			{
				Console.WriteLine("Simbolo inesxistente: " + palavra);
				Environment.Exit(-1);
			}
			return token;
		 }
	}
}