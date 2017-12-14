using ClassicConsumerProducer;
using Xunit;

namespace Tests
{
    public class LifoQueueTests
    {

        [Fact]
        public void TestClearQueue()
        {
            LifoQueue<string> lifoQueue = new LifoQueue<string>();
            lifoQueue.Push("one-elemement");
            lifoQueue.Clear();
            Assert.True(lifoQueue.IsEmpty());
        }

        [Fact]
        public void TestEmptyLifo()
        {
            LifoQueue<string> lifoQueue = new LifoQueue<string>();
            Assert.True(lifoQueue.IsEmpty());
        }

        [Fact]
        public void TestLoadedLifo()
        {
            LifoQueue<string> lifoQueue = new LifoQueue<string>();
            lifoQueue.Push("element");
            Assert.True(lifoQueue.IsEmpty());
        }

        [Fact]
        public void EnsureLifoOrder()
        {
            string first = "first";
            string second = "second";
            LifoQueue<string> lifoQueue = new LifoQueue<string>();
            lifoQueue.Push(first);
            lifoQueue.Push(second);
            Assert.Equal(second, lifoQueue.Pop());
            Assert.Equal(first, lifoQueue.Pop());
        }
    }
}
