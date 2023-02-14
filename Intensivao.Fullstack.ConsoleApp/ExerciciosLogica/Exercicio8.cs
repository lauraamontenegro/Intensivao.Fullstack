namespace Intensivao.Fullstack.ConsoleApp.ExerciciosLogica
{
    public class Exercicio8
    {
        public static void Vendas()
        {
            double fixo, vendas, comissao, SalFinal;

            Console.WriteLine("8º Um funcionário recebe um salário fixo mais 4% de comissão sobre as vendas. Faça um algoritmo que receba o salário fixo de um funcionário e o valor de suas vendas, calcule e mostre a comissão e o salário final do funcionário.");
            Console.WriteLine();

            Console.WriteLine("Digite o seu salário atual.");
            fixo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de vendas.");
            vendas = Convert.ToDouble(Console.ReadLine());

            comissao = (vendas * 4) / 100;
            SalFinal = (comissao + fixo);

            Console.WriteLine($"Seu salário final é: {SalFinal}");
        }
    }
}
