using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardápio
{
    public class Pedido
    {
        //criar funçao para ler
        public int numeroPedido = 0;




        public List<Produto> pedidos = new List<Produto>();





        public void ExbirPedido()
        {
            foreach (var pedido in pedidos)
            {
               
                
                Console.WriteLine($" Nome do produto: {pedido.Nome}");
                Console.WriteLine($" Peso do produto: {pedido.Peso}");
                Console.WriteLine($" Preço do produto: {pedido.Preco}");

                Console.WriteLine();
                Console.WriteLine();
            
            }
        
        }





    }
}
