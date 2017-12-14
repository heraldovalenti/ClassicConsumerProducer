using System;
namespace ClassicConsumerProducer
{
    public interface IQueue<T>
    {
        void Push(T element);

        T Pop();

        bool IsEmpty();

        void Clear();
    }
}
