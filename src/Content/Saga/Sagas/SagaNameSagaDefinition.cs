namespace Company.Sagas
{
    using MassTransit;

    public class SagaNameSagaDefinition :
        SagaDefinition<SagaNameSaga>
    {
        protected override void ConfigureSaga(IReceiveEndpointConfigurator endpointConfigurator, ISagaConfigurator<SagaNameSaga> sagaConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}