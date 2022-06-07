namespace ConsoleApp1
{
    class PreferentialClient_2 : AbstractClient
    {
        /// <summary>
        /// Конструктор для создания клиента
        /// </summary>
        /// <param name="type"> Тип Клиента</param>
        /// <param name="energy"> Потребленная энергия </param>
        public PreferentialClient_2(string type, int energy) : base(type, energy) { }

        /// <summary>
        /// Метод для вычисления стоимость услуг
        /// </summary>
        /// <returns> Стоимость услуг</returns>
        public override double Price()
        {
            if (Energy < Value.PreferentialEnergy)
                return 0;
            else
                return (Energy - Value.PreferentialEnergy) * Cost;
        }
    }
}
