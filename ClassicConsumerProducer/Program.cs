using System;
using System.Threading;

namespace ClassicConsumerProducer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IQueue<IConsumable> sharedQueue = new LifoQueue<IConsumable>();
            Producer p1 = new Producer(sharedQueue);
            Producer p2 = new Producer(sharedQueue);
            Consumer c1 = new Consumer(sharedQueue);
            Consumer c2 = new Consumer(sharedQueue);

            Thread tp1 = new Thread(() => ProducerFunction(p1));
            Thread tp2 = new Thread(() => ProducerFunction(p2));

            Thread tc1 = new Thread(() => ConsumerFunction(c1));
            Thread tc2 = new Thread(() => ConsumerFunction(c2));

            tp1.Start();
            tp2.Start();
            tc1.Start();
            tc2.Start();
        }

        static void ProducerFunction(Producer producer)
        {
            for (int i = 0; i < 10; i++)
            {
                producer.Produce();
                Thread.Sleep(200);
            }
        }

        static void ConsumerFunction(Consumer consumer)
        {
            for (int i = 0; i < 10; i++)
            {
                consumer.Consume();
                Thread.Sleep(200);
            }
        }
    }
}
