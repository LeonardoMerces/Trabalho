using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ativida 1\n");
            int i_tab = 0;
            Console.Write("Digite uma variável para definir a tabuada: ");
            i_tab = int.Parse(Console.ReadLine());
            Console.WriteLine("á tabuada é");
            Console.WriteLine("{0} x 1 = {1}", i_tab ,i_tab * 1);
            Console.WriteLine("{0} x 2 = {1}", i_tab ,i_tab * 2);
            Console.WriteLine("{0} x 3 = {1}", i_tab ,i_tab * 3);
            Console.WriteLine("{0} x 4 = {1}", i_tab ,i_tab * 4);
            Console.WriteLine("{0} x 5 = {1}", i_tab ,i_tab * 5);
            Console.WriteLine("{0} x 6 = {1}", i_tab ,i_tab * 6);
            Console.WriteLine("{0} x 7 = {1}", i_tab ,i_tab * 7);
            Console.WriteLine("{0} x 8 = {1}", i_tab ,i_tab * 8);
            Console.WriteLine("{0} x 9 = {1}", i_tab ,i_tab * 9);
            Console.WriteLine("{0} x 10 = {1}", i_tab ,i_tab * 10);
            Console.ReadLine();


            Console.WriteLine("\n\nAtivida 2\n");
            int i_laud = 0;
            Console.Write("Digite a quantidade laudas: ");
            i_laud = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor: {0}", i_laud * 50);
            Console.WriteLine("O valor Parcelado: {0}", (i_laud * 50) / 3);
            Console.ReadLine();
            

            Console.WriteLine("\n\nAtivida 3\n");
            string nm_01 = "";
            Console.Write("Digite seu nome: ");
            nm_01 = Console.ReadLine();
            Console.WriteLine("Bem-vindo ao nosso programa! Estamos animados para começar esta jornada com você {0}\n", nm_01);
            Console.Write("pressione enter para finalizar :)", nm_01); 
            nm_01 = Console.ReadLine();



            Console.WriteLine("\n\nAtivida BOSS\n");
            

            





        }
    }
}
