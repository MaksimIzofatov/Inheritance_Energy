using System;

namespace ConsoleApp1
{
    class AllClient 
    {
        private static Random _r = new Random();

        /// <summary>
        /// Массив клиентов
        /// </summary>
        private AbstractClient[] _clients = new AbstractClient[]
        {
            new NormalClient("Normal", _r.Next(50, 501)),
            new PreferentialClient_1("Preferential_1", _r.Next(50, 501)),
            new LimitClient("Limit", _r.Next(50, 501)),
            new PreferentialClient_2("Preferential_2", _r.Next(50, 501)),
        };

        /// <summary>
        /// Метод для сортировки и вывода клиентов по количествую потребленной энергии по убыванию
        /// </summary>
        public void SortEnergyDesc()
        {
            Array.Sort(_clients, new SortEnergyDesc());
            foreach(var client in _clients)
            {
                Console.WriteLine(client);
            }
        }

        /// <summary>
        /// Метод для сортировки и вывода клиентов по стоимости услуг по возрастанию
        /// </summary>
        public void SortPrice()
        {
            Array.Sort(_clients);
            foreach (var client in _clients)
            {
                Console.WriteLine(client);
            }
        }

        /// <summary>
        /// Метод для сортировки и вывода клиентов по типу
        /// </summary>
        public void SortName()
        {
            Array.Sort(_clients, new SortType());
            foreach (var item in _clients)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Метод для вычисления и вывода общей суммы потребленной энергии
        /// </summary>
        public void AllSum()
        {
            double sum = 0;
            foreach (var client in _clients)
            {
                sum += client.Price();
            }
            Console.WriteLine($"Общая сумма оплаты всех клиентов: {sum:f2}");
        }

        /// <summary>
        /// Метод для вычисления и вывода размера льготы
        /// </summary>
        public void SumBenefit()
        {
            double sum0 = 0;
            double sum = 0;
            foreach (var client in _clients)
            {
                sum0 += client.Energy * Value.Cost;
                sum += client.Price();
            }
            Console.WriteLine($"Общий размер льготы составляет: {sum0-sum:f2}");
        }
    }
}
