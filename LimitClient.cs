namespace ConsoleApp1
{
    class LimitClient : AbstractClient
    {
        /// <summary>
        /// Конструктор для создания клиента
        /// </summary>
        /// <param name="type"> Тип Клиента</param>
        /// <param name="energy"> Потребленная энергия </param>
        public LimitClient(string type, int energy) : base(type, energy) { }

        /// <summary>
        /// Метод для вычисления стоимость услуг
        /// </summary>
        /// <returns> Стоимость услуг</returns>
        public override double Price()
        {
            if (Energy < Value.LimitEnergy)
                return Energy * Cost;
            else
                return Value.LimitEnergy * Cost + (Energy - Value.LimitEnergy) * (Cost + Cost * 1 / 3);
        }
    }
}
