/*. Crie um programa para receber o salário bruto de um funcionário e o número de 
anos que ele está na empresa. O programa deve calcular o valor do aumento salario 
deste funcionário conforme tabela abaixo:
Condição % do aumento
Menos de 1 ano de trabalho ou salário 
maior que o teto de R$ 20.000,00
2% de aumento
Mais de um ano e menor que 5 anos 
6% de aumento
Mais de 5 anos 
8% de aumento
Salário abaixo do Piso de R$ 1500,00
15% de aumento
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest18_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário bruto do profissional:");
            double income =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o tempo de empresa do profissional:");
            double years = Convert.ToDouble(Console.ReadLine());

            if (income < 20000 || years < 1)
            {
                income = 0.02 * income;
                Math.Round(income, 2);
                Console.WriteLine("O aumento foi de :R${0}", income);

            }
            else if (years > 1 && years < 5)
            {
                income = 0.06 * income;
                Math.Round(income,2);
                Console.WriteLine("O aumento foi de :R${0}", income);

            }
            else if (years > 5)
            {
                income = 0.08 * income;
                Math.Round(income, 2);
                Console.WriteLine("O aumento foi de :R${0}", income);
            }

            else if (years > 5)
            {
                income = 0.15 * income;
                Math.Round(income, 2);
                Console.WriteLine("O aumento foi de :R${0}", income);

            }
                Console.ReadLine();
            }
    }
}
