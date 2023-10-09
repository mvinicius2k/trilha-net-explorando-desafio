using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Exceptions
{
	/// <summary>
	/// Sinaliza que alguma validação envolvendo limites falhou
	/// </summary>
	[Serializable]
	public class LimiteException : Exception
	{
		public LimiteException() { }
		public LimiteException(string message) : base(message) { }
		public LimiteException(string message, Exception inner) : base(message, inner) { }
		protected LimiteException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
