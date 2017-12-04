using System.Collections.Generic;

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
	public class Buffer
	{
		internal int pos = 0;
		internal readonly string EOL = ";";
		internal List<string> palavras = new List<string>();

		public string Buffer(string codObjt, int pos)
		{

			string arqaux = "";
			char lookAhead = ' ';
			for (int i = pos;i < codObjt.Length ;i++)
			{

				arqaux += codObjt[i];


				if (arqaux.Contains(EOL))
				{


					if (i != codObjt.Length - 1)
					{
						this.pos++;
					this.Buffer(codObjt, this.pos);


					}
					palavras.Add(arqaux);
					return arqaux;
				}
				else
				{
					lookAhead = codObjt[i + 1];

				}
				 if (lookAhead == ' ')
				 {
					this.pos = i + 2;

					this.Buffer(codObjt, this.pos);
					palavras.Add(arqaux);
					return arqaux;


				 }
				else if (lookAhead == ';' || lookAhead == ')' || lookAhead == ',' || lookAhead == '(')
				{
					this.pos = i + 1;
					this.Buffer(codObjt, this.pos);
					palavras.Add(arqaux);
					return arqaux;


				}
				else if (arqaux.Contains("(") || arqaux.Contains(","))
				{
					this.pos = i + 1;
					this.Buffer(codObjt, this.pos);
					palavras.Add(arqaux);
					return arqaux;


				}


			}
		return "ERROR";

		}
	}

}