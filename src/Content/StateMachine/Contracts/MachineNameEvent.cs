namespace Contracts
{
    using System;

    public record MachineNameEvent
    {
        public Guid CorrelationId { get; init; }
        public string Value { get; init; }
    }
}