namespace Company.Activities
{
    using System.Threading.Tasks;
    using MassTransit;

    public class ActivityNameActivity :
        IExecuteActivity<ActivityNameArguments>
    {
        public async Task<ExecutionResult> Execute(ExecuteContext<ActivityNameArguments> context)
        {
            await Task.Delay(100);

            return context.Completed();
        }
    }
}