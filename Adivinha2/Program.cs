using System.Net.Mail;

namespace Adivinha2
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            int continuar = 1, password = 0, attempt = 0, number = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("sorteando números entr 1 e 10");
                password = sorteio(password);

                Console.WriteLine("Começou! Tente adivinhar o número: ");
                attempt = 0;

                do
                {
                    attempt++;
                    Console.WriteLine("Tentativa n°"+attempt);
                    Console.WriteLine("Digite um número: ");
                    number = int.Parse(Console.ReadLine());
                    dicas(number, password, attempt);
                }
                while (number!=password);
                Console.WriteLine("Digite 0 para continiar ou qualquer outro número para continuar");
                continuar = int.Parse(Console.ReadLine());
            }
            while (continuar!=0);

            int sorteio (int password)
            {
                Random n = new Random();
                password = Convert.ToInt32(n.Next(1, 10));
                return password;

            }

            void dicas(int  number, int password, int attempt)
            {
                if (number > password)
                {
                    Console.WriteLine("O número sorteado é menor que" + number);
                }
                else
                    if (number < password)
                    Console.WriteLine("O número sorteado é maior que" + number);
                else
                    Console.WriteLine("Parabéns!!! Você acertou o número em" + "tentativas");
                
            }
        
        }
    }
}
//aula 11/09/2024