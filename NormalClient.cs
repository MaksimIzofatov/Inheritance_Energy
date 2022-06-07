namespace ConsoleApp1
{
    internal class NormalClient : AbstractClient
    {
        /// <summary>
        /// Конструктор для создания клиента
        /// </summary>
        /// <param name="type"> Тип Клиента</param>
        /// <param name="energy"> Потребленная энергия </param>
        public NormalClient(string type, int energy) : base(type, energy) { }

        /// <summary>
        /// Метод для вычисления стоимость услуг
        /// </summary>
        /// <returns> Стоимость услуг</returns>
        public override double Price() => Energy * Cost;
    }
}
