namespace Intensivao.Fullstack.ConsoleApp.ExerciciosLogica
{
    internal class Exercicio6
    {
        public static void Peso()

        {
            Double PesoPrato, ValorPagar;


            Console.WriteLine("6º O restaurante sancho-pança cobra R$12,00 por cada quilo de refeição. Escreva um algoritmoque leia o peso do prato montado pelo cliente(em quilos) e imprima o valor a pagar. Assuma que a balança já desconte o peso do prato.");
            Console.WriteLine();


            Console.WriteLine("QUAL O PESO DO PRATO:  ");
            PesoPrato = Convert.ToDouble(Console.ReadLine());

            ValorPagar = PesoPrato * 12;

            Console.WriteLine($"VALOR A PAGAR =  R$ {ValorPagar}");


        }
    }
}
