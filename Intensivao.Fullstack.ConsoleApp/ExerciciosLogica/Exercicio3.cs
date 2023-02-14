namespace Intensivao.Fullstack.ConsoleApp.ExerciciosLogica
{
    public class Exercicio3
    {
        public static void Media()
        {

            double nota1, nota2, nota3, nota4;
            double media;


            Console.WriteLine("Digite a primeira nota");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;


            if (media < 4)
            {
                Console.WriteLine("O aluno está abaixo da média!");
            }


            else if (media >= 4 && media < 7)
            {
                Console.WriteLine("O aluno está na média!");
            }

            else if (media >= 7)
            {
                Console.WriteLine("O aluno está acima da média!");
            }
        }
    }
}