namespace Company.StateMachines
{
    using Contracts;
    using MassTransit;

    public class MachineNameStateMachine :
        MassTransitStateMachine<MachineNameState> 
    {
        public MachineNameStateMachine()
        {
            InstanceState(x => x.CurrentState, Created);

            Event(() => MachineNameEvent, x => x.CorrelateById(context => context.Message.CorrelationId));

            Initially(
                When(MachineNameEvent)
                    .Then(context => context.Saga.Value = context.Message.Value)
                    .TransitionTo(Created)
            );

            SetCompletedWhenFinalized();
        }

        public State Created { get; private set; }

        public Event<MachineNameEvent> MachineNameEvent { get; private set; }
    }
}
