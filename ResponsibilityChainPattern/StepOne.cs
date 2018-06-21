using System;

namespace ResponsibilityChainPattern
{
    public class StepOne : StepBase
    {
        public override void InvokeHandle(StepContext stepContext)
        {
            if (stepContext.Number > 0 && stepContext.Number <= 100)
            {
                Console.WriteLine($"值在100-200之间");
            }
            else
            {
                base._StepBase.InvokeHandle(stepContext);
            }
        }
    }
}
