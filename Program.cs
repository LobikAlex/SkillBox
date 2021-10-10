using System;

namespace SkillBoxMOD2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Лобик Александр Викторович";
            short age = 41;
            string email = "lobikalex@mail.ru";
            Double GeekRate = 99.9;
            Double MathRate = 90.1;
            Double PhisRate = 80.5;

            string pattern = " ФИО разработчика: {0}\n Возраст: {1}\n Email: {2}\n Баллы по прогамированию: {3:00.0}\n Баллы по математике: {4:00.0}\n Баллы по физике: {5:00.0}\n ";
            Console.WriteLine(
                pattern,
                FullName,
                age,
                email,
                GeekRate,
                MathRate,
                PhisRate);
            
            //Console.ReadKey();

            // вторая чать задания. Вывод среднего арифметического
            
            double sum = (GeekRate + MathRate + PhisRate) / 3;     

            Console.WriteLine($"Общая сумма баллов разработчика: {sum:00.00} баллов or " + sum.ToString("##.####"));

            Console.ReadKey();


        }
    }
}
