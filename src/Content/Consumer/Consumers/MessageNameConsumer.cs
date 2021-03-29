namespace Company.Consumers
{
    using System;
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;

    public class MessageNameConsumer :
        IConsumer<MessageName>
    {
        public Task Consume(ConsumeContext<MessageName> context)
        {
            return Task.CompletedTask;
        }
    }
}