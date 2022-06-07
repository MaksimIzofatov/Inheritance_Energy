using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AllClient allClient = new AllClient();
            Console.WriteLine("Клиенты расположены по убыванию по количеству потребленной энергии");
            allClient.SortEnergyDesc();
            Console.WriteLine("\nКлиенты расположены по возрастанию по величине оплаты");
            allClient.SortPrice();
            Console.WriteLine("\nКлиенты расположены по типу");
            allClient.SortName();
            Console.WriteLine();
            allClient.AllSum(); // общая сумма
            Console.WriteLine();
            allClient.SumBenefit(); // общий размер льготы
        }
    }
}
