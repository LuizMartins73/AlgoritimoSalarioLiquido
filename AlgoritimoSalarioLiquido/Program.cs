using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoSalarioLiquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu salário bruto: ");
            double sb = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do Vale Alimentação: ");
            double vl = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de filhos os quais você possui: ");
            double qtdf = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor por filho: ");
            double vf = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de horas extras feitas: ");
            double he = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da hora extra: ");   
            double vhe = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do INSS: ");
            double inss = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do IRPF: ");
            double irpf = double.Parse(Console.ReadLine());

            double sl = sb + vl + (qtdf * vf) + (he * vhe) - inss - irpf;
                Console.WriteLine("O valor do salário líquido é de: R$"+ sl);

            Console.ReadKey();
        }
    }
}

