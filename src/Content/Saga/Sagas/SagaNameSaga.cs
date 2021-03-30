namespace Company.Sagas
{
    using System;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using MassTransit;
    using MassTransit.Saga;
    using Contracts;

    public class SagaNameSaga :
        ISaga,
        InitiatedBy<InitiateSagaName>,
        Orchestrates<UpdateSagaName>,
        Observes<NotifySagaName, SagaNameSaga>
    {
        public Guid CorrelationId { get; set; }
        public string Value { get; set; }

        public Expression<Func<SagaNameSaga, NotifySagaName, bool>> CorrelationExpression =>
            (saga, message) => saga.Value == message.Value;

        public Task Consume(ConsumeContext<InitiateSagaName> context)
        {
            Value = context.Message.Value;

            return Task.CompletedTask;
        }

        public Task Consume(ConsumeContext<UpdateSagaName> context)
        {
            Value = context.Message.Value;
            
            return Task.CompletedTask;
        }

        public Task Consume(ConsumeContext<NotifySagaName> context)
        {
            return Task.CompletedTask;
        }
    }
}

