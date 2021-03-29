namespace Company.Consumers
{
    using GreenPipes;
    using MassTransit;
    using MassTransit.ConsumeConfigurators;
    using MassTransit.Definition;

    public class MessageNameConsumerDefinition :
        ConsumerDefinition<MessageNameConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<MessageNameConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}