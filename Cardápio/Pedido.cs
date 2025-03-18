using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardápio
{
    public class Pedido
    {


        public List<Produto> pedidos = new List<Produto>();

        List<Produto> pedidos_list = new List<Produto>();
        public void ExbirPedido()
        {
            foreach (var pedido in pedidos)
            {

                Console.WriteLine($"-{pedido.Nome}");
                Console.WriteLine($"-R${pedido.Preco}");

            }

        }

        public double Total()
        {
            double total = 0;
            foreach (Produto pedido in pedidos)
            {
                total += pedido.Preco;

            }
            return total;

        }

    }
}
