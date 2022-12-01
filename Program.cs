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

            float sumPoints = pointsIT + pointsMaths + pointsPhysics;

            float meanPoints = sumPoints / 3;

            string pattern = $"ФИО: {fullName} \nВозраст: {age} \nEmail: {email} \nБаллы по информатике: {pointsIT} \nБаллы по математике: {pointsMaths} \nБаллы по физике: {pointsPhysics} \nОбщая сумма баллов: {sumPoints} \nСредний балл {meanPoints}";
            Console.WriteLine(pattern,
                              fullName,
                              age,
                              email,
                              pointsIT,
                              pointsMaths,
                              pointsPhysics,
                              sumPoints,
                              meanPoints);
            Console.ReadKey();
        }
    }
           
            
}
