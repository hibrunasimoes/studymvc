using System;
using firstmvc.Models;

namespace firstmvc.Database
{
	public class PedidoRepository : IPedidoRepository
	{

		public Pedido ObterPedido()
		{
			return new Pedido();
		}
	}
    public interface IPedidoRepository
    {
        Pedido ObterPedido();

    }
}

