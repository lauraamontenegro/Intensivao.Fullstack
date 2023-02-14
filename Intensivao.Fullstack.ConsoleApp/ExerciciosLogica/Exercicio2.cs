namespace Intensivao.Fullstack.ConsoleApp.ExerciciosLogica
{
    public class Exercicio2
    {
        public static void Salario()
        {
            double salario, percentual;

            Console.WriteLine("2º Elabore um algoritmo que recebe o salário mensal atual de um funcionário e um percentual de reajuste e exiba o novo salário.");
            Console.WriteLine();

            Console.WriteLine("Digite seu salário atual");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a % e aperte ENTER para ver o seu novo salário");
            percentual = Convert.ToDouble(Console.ReadLine());



            if (salario >= 0)
            {

                percentual = salario + (salario * percentual / 100);
                Console.WriteLine(percentual);


            }

        }
    }
}