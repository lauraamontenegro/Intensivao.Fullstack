namespace Intensivao.Fullstack.ConsoleApp.ExerciciosLogica
{
    internal class Exercicio7
    {
        public static void Dias()
        {
            {
                int DiasNoMes = 30;
                int DiasSemAcidente = 365;
                int QtdAnos;

                Console.WriteLine("7º Uma fábrica controla o tempo de trabalho sem acidentes pela quantidade de dias. Faça um\r\nalgoritmo para converter este tempo em anos, meses e dias. Assuma que cada mês possui sempre\r\n30 dias");
                Console.WriteLine();

                QtdAnos = (DiasSemAcidente / 12);
                int QtdMeses = DiasSemAcidente / DiasNoMes - QtdAnos * 12;
                int QtdDias = DiasSemAcidente % DiasNoMes;
                Console.WriteLine("{0} ano(s), {1} mes(es) e {2} dia(s).", QtdAnos, QtdMeses, QtdDias);


                Console.ReadLine();
            }
        }
    }
}
