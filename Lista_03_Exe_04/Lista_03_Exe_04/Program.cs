using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int NH, ST = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.Write("Digite o total de horas trabalhadas no dia {0}: ",i+1);
                NH = int.Parse(Console.ReadLine());
                NH = NH * 10;
                ST = ST + NH;
            }
            Console.WriteLine("O Salario total é: {0:c}", ST);
            Console.ReadKey();
        }
    }
}
