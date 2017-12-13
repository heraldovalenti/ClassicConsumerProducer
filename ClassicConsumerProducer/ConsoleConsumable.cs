using System;
namespace ClassicConsumerProducer
{
    public class ConsoleConsumable : IConsumable
    {
        readonly int id;

        public ConsoleConsumable()
        {
            Random rnd = new Random();
            id = rnd.Next(1,999);
            Console.WriteLine("ConsoleConsumable {0} was created...", id);
        }

        public void Consume()
        {
            Console.WriteLine("ConsoleConsumable {0} was consumed!!!", id);
        }
    }
}
