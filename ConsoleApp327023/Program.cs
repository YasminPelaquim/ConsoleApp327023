using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp327023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos meses se passaram depois do seu aniversário: ");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dias se passaram desde o último mês: ");
            int dias = int.Parse(Console.ReadLine());

            int anosdias = anos * 365;

            int mesesdias = meses * 30;

            int total = anosdias + mesesdias + dias;

            Console.WriteLine("O total de dias vividos é: " + total);

            Console.ReadKey();

        }
    }
}
