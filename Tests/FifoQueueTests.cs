using ClassicConsumerProducer;
using Xunit;

namespace Tests
{
    public class FifoQueueTests
    {

        [Fact]
        public void TestClearQueue()
        {
            FifoQueue<string> fifoQueue = new FifoQueue<string>();
            fifoQueue.Push("one-element");
            Assert.False(fifoQueue.IsEmpty());
        }

        [Fact]
        public void TestEmptyFifo()
        {
            FifoQueue<string> fifoQueue = new FifoQueue<string>();
            Assert.True(fifoQueue.IsEmpty());
        }

        [Fact]
        public void TestLoadedFifo()
        {
            FifoQueue<string> fifoQueue = new FifoQueue<string>();
            fifoQueue.Push("element");
            Assert.False(fifoQueue.IsEmpty());
        }

        [Fact]
        public void EnsureFifoOrder()
        {
            string first = "first";
            string second = "second";
            FifoQueue<string> fifoQueue = new FifoQueue<string>();
            fifoQueue.Push(first);
            fifoQueue.Push(second);
            Assert.Equal(first, fifoQueue.Pop());
            Assert.Equal(second, fifoQueue.Pop());
        }
    }
}
