using System;

namespace Projeto_Pedido {
	public class ErrorMessageException : Exception {

		public ErrorMessageException(string msg)
			:base(msg)
		{
		}
	}
}
