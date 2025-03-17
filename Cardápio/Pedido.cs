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
       




        public List<Produto> pedidos = new List<Produto>();

        List<Produto> pedidos_list = new List<Produto>();



        public void ExbirPedido()
        {
            foreach (var pedido in pedidos)
            {

                
                Console.WriteLine($" Nome do produto: {pedido.Nome}");
                Console.WriteLine($" Preço do produto: {pedido.Preco}");
                
                

                Console.WriteLine();
                Console.WriteLine();
              
                //add preço total
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
