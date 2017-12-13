//using Xunit;

namespace ClassicConsumerProducer.Test
{
    public class LifoQueueTests
    {

        //[Fact]
        public void TestEmptyLifo()
        {
            LifoQueue<string> lifoQueue = new LifoQueue<string>();
            //Assert.True(lifoQueue.IsEmpty());
        }

        //[Fact]
        public void TestLoadedLifo()
        {
            LifoQueue<string> lifoQueue = new LifoQueue<string>();
            lifoQueue.Push("one-element");
            //Assert.False(lifoQueue.IsEmpty());
        }
    }
}
