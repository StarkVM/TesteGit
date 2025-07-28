using System;

public class Program
{
    static void Main(string[] args)
    {
        Calcular();
    }

    static void Calcular()
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("EH PRIMO OU NAO?\n");
            Console.Write("Digite um numero inteiro: ");
            var num = Console.ReadLine();

            if (int.TryParse(num, out int number))
            {
                bool primo = true;

                if (number == 1)
                {
                    Console.WriteLine("Nao eh primo.\n");
                }
                else if (number == 0)
                {
                    primo = false;
                }
                else if (number == 2)
                {

                }

                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        primo = false;

                    }
                }

                Console.Clear();

                if (primo == true)
                {
                    Console.WriteLine($"O numero {number} eh primo\n");
                }
                else
                {
                    Console.WriteLine($"O numero {number} nao eh primo\n");
                }
            }
            else
            {
                Console.WriteLine("Invalido.\n");
            }

            string escolha = "0";
            while (escolha != "1" && escolha != "2")
            {
                Console.Write("Deseja tentar de novo? 1-Sim 2-Nao: ");
                escolha = Console.ReadLine();
                Console.Clear();
            }

            if (escolha == "2")
            {
                Console.Write("Encerrado.");
                return;
            }
            
        }
    }

}



































































































































