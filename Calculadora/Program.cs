using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string nova = "";
            int oper = 0;
            int conta = 0;

            do { 
                Console.WriteLine("Escolha a operacao:");
                Console.WriteLine("1. Soma ");
                Console.WriteLine("2. Subtracao ");
                Console.WriteLine("3. Multiplicacao ");
                Console.WriteLine("4. Divisao ");

                oper = Convert.ToInt32(Console.ReadLine());
            
                while (oper != 1 && oper != 2 && oper != 3 && oper != 4)
                {
                    Console.WriteLine("Digite um valor valido!");
                    oper = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Digite o primeiro valor...");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor...");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("O resultado é:");

                if (oper == 1)
                    conta = n1 + n2;

                if (oper == 2)
                    conta = n1 - n2;


                if (oper == 3)
                    conta = n1 * n2;

                if (oper == 4)
                    conta = n1 / n2;
            
                Console.WriteLine(conta);

                Console.WriteLine("Deseja fazer outra conta?");
                Console.WriteLine("s/n");
                nova = Console.ReadLine();

                while (nova != "s" && nova != "n")
                {
                    Console.WriteLine("Digite um valor valido!");
                    nova = Console.ReadLine();
                }

            } while (nova == "s") ;

            Console.WriteLine("Bons estudos!!");
            Console.ReadKey();
        }
    }
}
