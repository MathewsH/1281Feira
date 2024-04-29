using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Feira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double total = 0.0;
                int m = int.Parse(Console.ReadLine());
                string[] produtos = new string[m];
                double[] produtosP = new double[m];
                for (int j = 0; j < m; j++)
                {
                    string[] produto = Console.ReadLine().Split(' ');
                    produtos[j] = produto[0];
                    produtosP[j] = double.Parse(produto[1],CultureInfo.InvariantCulture);
                }
                int p = int.Parse(Console.ReadLine());
                for (int j = 0;j < p; j++)
                {
                    string[] pedido = Console.ReadLine().Split(' ');
                    for (int l = 0; l < m; l++)
                    {
                        if (pedido[0] == produtos[l])
                        {
                        
                            total += produtosP[l]*int.Parse(pedido[1]);
                            break;
                        }
                    }
                }
                Console.WriteLine($"R$ {total.ToString("F2",CultureInfo.InvariantCulture)}");

            }
            Console.ReadLine();
        }
    }
}
