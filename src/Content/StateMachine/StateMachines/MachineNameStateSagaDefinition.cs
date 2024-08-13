namespace Company.StateMachines
{
    using MassTransit;

    public class MachineNameStateSagaDefinition :
        SagaDefinition<MachineNameState>
    {
        protected override void ConfigureSaga(IReceiveEndpointConfigurator endpointConfigurator, ISagaConfigurator<MachineNameState> sagaConfigurator, IRegistrationContext context)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));

            endpointConfigurator.UseInMemoryOutbox(context);
        }
    }
}