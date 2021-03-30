namespace Company.Activities
{
    using System.Threading.Tasks;
    using MassTransit;
    using MassTransit.Courier;

    public class ActivityNameActivity :
        IActivity<ActivityNameArguments, ActivityNameLog>
    {
        public async Task<ExecutionResult> Execute(ExecuteContext<ActivityNameArguments> context)
        {
            await Task.Delay(100);

            return context.Completed<ActivityNameLog>(new 
            {
                Value = context.Arguments.Value
            });
        }

        public async Task<CompensationResult> Compensate(CompensateContext<ActivityNameLog> context)
        {
            await Task.Delay(100);
            
            return context.Compensated();
        }
    }
}