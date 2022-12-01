using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Маргулис Инна Даниловна";
            int age = 17;
            string email = "inna2828@inbox.ru";
            float pointsIT = 93.8f;
            float pointsMaths = 88.78f;
            float pointsPhysics = 99.995f;

            
            string pattern = $"ФИО: {fullName} \nВозраст: {age} \nEmail: {email} \nБаллы по информатике: {pointsIT} \nБаллы по математике: {pointsMaths} \nБаллы по физике: {pointsPhysics}";
            Console.WriteLine(pattern,
                              fullName,
                              age,
                              email,
                              pointsIT,
                              pointsMaths,
                              pointsPhysics);
            Console.ReadKey();

            float sumPoints = pointsIT + pointsMaths + pointsPhysics;
            Console.WriteLine($"Общая сумма баллов: {sumPoints}");
            Console.ReadKey();

            float meanPoints = sumPoints / 3;
            Console.WriteLine($"Средний балл {meanPoints}");
            Console.ReadKey();

        }
    }
           
            
}
