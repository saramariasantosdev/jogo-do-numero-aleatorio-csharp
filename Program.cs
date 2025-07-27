using System;

public class JogoNumeroAleatorio
{
    public static void Main(string[] args)
    {
        int minimo = 1;
        int maximo = 10;

        Random random = new Random();
        int numeroAleatorio = random.Next(minimo, maximo);

        do
        {
            Console.Write($"Escolha um número de {minimo} a {maximo}: ");
            string numeroEscolhido = Console.ReadLine()!;

            if (int.Parse(numeroEscolhido) > numeroAleatorio)
            {
                Console.WriteLine("Número aleatório é menor!");
            }
            else if (int.Parse(numeroEscolhido) < numeroAleatorio)
            {
                Console.WriteLine("Número aleatório é maior!");
            }
            else
            {
                Console.WriteLine($"Parabéns, você acertou o número aleatório: {numeroAleatorio}");
                break;
            }
        } while (true);
    }
}
