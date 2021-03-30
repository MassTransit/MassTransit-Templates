namespace Contracts
{
    using System;
    using MassTransit;

    public record UpdateSagaName :
        CorrelatedBy<Guid>
    {
        public Guid CorrelationId { get; init; }
        public string Value { get; init; }
    }
}