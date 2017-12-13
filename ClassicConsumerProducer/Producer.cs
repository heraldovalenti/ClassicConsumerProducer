using System;
namespace ClassicConsumerProducer
{
    public class Producer
    {
        readonly IQueue<IConsumable> queue;

        public Producer(IQueue<IConsumable> queue)
        {
            this.queue = queue;
        }

        public void Produce()
        {
            IConsumable product = new ConsoleConsumable();
            queue.Push(product);
        }

    }
}
