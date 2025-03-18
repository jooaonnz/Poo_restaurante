using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Cardápio
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Seja bem-vindo, ao TopLanches. \n");
                Console.WriteLine("Algumas das opções da casa: ");

                static void ExibirCardápio()
                {
                    Console.WriteLine("1-R$22,56_____________X-SALADA 300G ");
                    Console.WriteLine("2-R$18,97_____________X-BACON 320G ");
                    Console.WriteLine("3-R$17,37_____________X-FRANGO 290G ");
                    Console.WriteLine("4-R$69,89_____________PORÇÃO DE FRITAS 600G: ");
                    Console.WriteLine("5-R$89,80_____________PORÇÃO FRITAS E PESTISCOS 850G \n");
                    Console.WriteLine("BEBIDAS");
                    Console.WriteLine("6-R$10,00_____________COCA-COLA 2 L");
                    Console.WriteLine("7-R$8,50______________SPRITE 2 L");
                    Console.WriteLine("8-R$8,00______________GUARÁNA 2 L");
                    Console.WriteLine("9-R$12,00_____________HEINEKEN 360ML");
                    Console.WriteLine("10-R$5,00_____________BHRAMA DUPLO MALTE 250ML \n");
                }

                Produto Lanche1 = new Produto();
                Lanche1.Nome = "X-SALADA 300g";
                Lanche1.Preco = 22.50;

                Produto Lanche2 = new Produto();
                Lanche2.Nome = "X-BACON 320g";
                Lanche2.Preco = 18.90;

                Produto Lanche3 = new Produto();
                Lanche3.Nome = "X-FRANGO 290g";
                Lanche3.Preco = 17.35;

                Produto Lanche4 = new Produto();
                Lanche4.Nome = "PORÇÃO DE FRITAS 600g";
                Lanche4.Preco = 69.90;

                Produto Lanche5 = new Produto();
                Lanche5.Nome = "PORÇÃO DE FRITAS E PETISCOS 850g";
                Lanche5.Preco = 89.80;

                Produto Bebida1 = new Produto();
                Bebida1.Nome = "COCA-COLA 2L";
                Bebida1.Preco = 10.00;

                Produto Bebida2 = new Produto();
                Bebida2.Nome = "SPRITE 2L";
                Bebida2.Preco = 8.50;

                Produto Bebida3 = new Produto();
                Bebida3.Nome = "GUARÁNA 2L";
                Bebida3.Preco = 8.00;

                Produto Bebida4 = new Produto();
                Bebida4.Nome = "HEINEKEN 350ML";
                Bebida4.Preco = 12.00;

                Produto Bebida5 = new Produto();
                Bebida5.Nome = "BHRAMA DUPLO MALTE 250ML";
                Bebida5.Preco = 5.00;

                Operacao operacao = new Operacao();




                bool ativado = true;



                while (ativado)
                {
                    int op = -1;
                    Console.WriteLine("Faça seu pedido: ");

                    Pedido pegarPedido = new Pedido();
                    while (op != 0)
                    {
                        ExibirCardápio();
                        Console.WriteLine("Qual será seu pedido? ");
                        Console.WriteLine("Para finalizar pedido digite 0.");
                        op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();



                        switch (op)
                        {
                            case 0:
                                Console.WriteLine("Você deseja fazer mais algum pedido? (s/n)");
                                break;

                            case 1:
                                pegarPedido.pedidos.Add(Lanche1);

                                break;

                            case 2:
                                pegarPedido.pedidos.Add(Lanche2);

                                break;

                            case 3:
                                pegarPedido.pedidos.Add(Lanche3);

                                break;

                            case 4:
                                pegarPedido.pedidos.Add(Lanche4);

                                break;

                            case 5:
                                pegarPedido.pedidos.Add(Lanche5);

                                break;

                            case 6:
                                pegarPedido.pedidos.Add(Bebida1);

                                break;

                            case 7:
                                pegarPedido.pedidos.Add(Bebida2);

                                break;

                            case 8:
                                pegarPedido.pedidos.Add(Bebida3);

                                break;

                            case 9:
                                pegarPedido.pedidos.Add(Bebida4);

                                break;

                            case 10:
                                pegarPedido.pedidos.Add(Bebida5);

                                break;
                            default:
                                throw new Exception("ESCOLHA UM ITEM VÁLIDO!!");

                        }

                    }


                    string Resp = Console.ReadLine();
                    string RespC = Resp.ToLower();
                    if (RespC != "s" && RespC != "n")
                    {
                        throw new FormatException();
                    }

                    ativado = RespC == "s" ? true : false;
                    operacao.pedidos.Add(pegarPedido);

                    Console.Clear();


                }

                int numeroPedido = 0;

                foreach (var p in operacao.pedidos)
                {
                    numeroPedido += 1;

                    Console.WriteLine($" Pedido: #{numeroPedido}");
                    Console.WriteLine("------------------------------------");
                    p.ExbirPedido();
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Valor total do pedido: R${p.Total()}");
                    Console.WriteLine("------------------------------------");
                }


            }

            catch (FormatException)
            {
                Console.WriteLine($"ERRO:DIGITE UMA OPÇÃO VÁLIDA!!!!");

            }

            catch (Exception ex)
            {
                Console.WriteLine($"ERRO:{ex.Message}");
            }

        }

    }
}