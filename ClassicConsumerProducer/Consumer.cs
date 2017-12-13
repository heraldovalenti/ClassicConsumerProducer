using System;
namespace ClassicConsumerProducer
{
    public class Consumer
    {
        readonly IQueue<IConsumable> queue;

        public Consumer(IQueue<IConsumable> queue)
        {
            this.queue = queue;
        }

        public void Consume()
        {
            if (!queue.IsEmpty())
            {
                queue.Pop().Consume();
            }
        }
    }
}