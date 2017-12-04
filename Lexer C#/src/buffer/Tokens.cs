namespace buffer
{


	/// 
	/// <summary>
	/// @author Usuario
	/// </summary>
	public class Tokens
	{
		private string nome_token;
		private string descricao;
		internal string valor;

		public Tokens(string nome_token, string descricao, string valor)
		{
			this.nome_token = nome_token;
			this.descricao = descricao;
			this.valor = valor;
		}


		public virtual string Nome_token
		{
			set
			{
				this.nome_token = value;
			}
		}
		public virtual string Descricao
		{
			set
			{
				this.descricao = value;
			}
			get
			{
				return this.descricao;
			}
		}

		public virtual string Nome_Token
		{
			get
			{
				return this.nome_token;
			}
		}
	}

}