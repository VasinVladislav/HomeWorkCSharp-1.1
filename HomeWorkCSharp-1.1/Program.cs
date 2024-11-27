using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1. Вывести на экран число с точностью до сотых.
            Random rnd = new Random();  //Создание объекта для генерации чисел.
            double number = rnd.NextDouble() + rnd.Next(0, 9);   //Сложение рандомного натурального числа и рандомного целого числа.
            string value = string.Format("{0:f}", number);   //Преревод числительной переменной в строку и форматирование дробного числа.
            Console.WriteLine(value);
        }
    }
}
