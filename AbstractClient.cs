using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal abstract class AbstractClient : IComparable<AbstractClient>
    {
        /// <summary>
        /// Номер типа клиента
        /// </summary>
        public int TypeNumber { get; protected set; }
        /// <summary>
        /// Тип Клиента
        /// </summary>
        public string Type { get; protected set; }
        /// <summary>
        /// Потребленная энергия
        /// </summary>
        public int Energy { get; protected set; }
        /// <summary>
        /// Цена за единицу энергии
        /// </summary>
        public double Cost { get; protected set; }

        /// <summary>
        /// Конструктор для создания Клиентов
        /// </summary>
        /// <param name="type"> Тип клиента </param>
        /// <param name="energy"> Потребленная энергия </param>
        public AbstractClient(string type, int energy)
        {
            Type = type;
            switch (Type)
            {
                case "Normal": TypeNumber = 1; break;
                case "Limit": TypeNumber = 2; break;
                case "Preferential_1": TypeNumber = 3; break;
                case "Preferential_2": TypeNumber = 4; break;
                default:TypeNumber = 5; break;
            }
            Energy = energy;
            Cost = Value.Cost;
        }

        /// <summary>
        /// Метод для сравнения клиентов по стоимости услуг
        /// </summary>
        /// <param name="other"> Другой клиент</param>
        /// <returns> -1 - если стоимость услуг этого клиента меньше, чем другого клиента
        /// 0 - если стоимость услуг этого клиента равна стоимости услуг другого клиента
        /// 1 - если стоимость услуг этого клиента больше, чем другого клиента</returns>
        public int CompareTo(AbstractClient other) => Price().CompareTo(other.Price());

        /// <summary>
        /// Метод для вычисления стоимости услуг
        /// </summary>
        /// <returns></returns>
        public abstract double Price();

        /// <summary>
        /// Метод для вывода информации о клиенте
        /// </summary>
        /// <returns> Информация о клиенте </returns>
        public override string ToString() => $"Клиент {Type} использовал {Energy} энергии на общую сумму {Price():f2}";
    }
}
