using System.Collections.Generic;

namespace ClassicConsumerProducer
{
    public class LifoQueue<T> : IQueue<T>
    {
        readonly LinkedList<T> queue;
        readonly object sync = new object();

        public LifoQueue()
        {
            this.queue = new LinkedList<T>();
        }

        public void Clear()
        {
            lock (sync)
            {
                queue.Clear();
            }
        }

        public bool IsEmpty()
        {
            lock (sync)
            {
                return queue.Count == 0;
            }
        }

        public T Pop()
        {
            T popedElement = default(T);
            lock (sync)
            {
                if (!IsEmpty())
                {
                    popedElement = queue.First.Value;
                    queue.RemoveFirst();
                }
            }
            return popedElement;
        }

        public void Push(T toBePushed)
        {
            lock (sync)
            {
                queue.AddFirst(toBePushed);
            }
        }
    }
}
