namespace Contracts
{
    using System;
    using MassTransit;

    public record InitiateSagaName :
        CorrelatedBy<Guid>
    {
        public Guid CorrelationId { get; init; }
        public string Value { get; init; }
    }
}