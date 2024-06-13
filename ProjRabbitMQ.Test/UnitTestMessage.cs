using ProjRabbitMQ.Consumer.Services;
using ProjRabbitMQ.Models;

namespace ProjRabbitMQ.Test
{
    public class UnitTestMessage
    {
        [Fact]
        public void TestCall()
        {
            for (int i = 0; i < 10000; i++)
            {
                var msg = new Message() { Description = $"Teste-{i}" };
                Message msgOut = new MessageService().PostMessage(msg).Result;
            }

            Assert.True(true);
        }
    }
}