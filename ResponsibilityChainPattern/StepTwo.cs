using System;

namespace ResponsibilityChainPattern
{
    public class StepTwo: StepBase
    {
        public override void InvokeHandle(StepContext stepContext)
        {
            if (stepContext.Number > 100 && stepContext.Number <= 200)
            {
                Console.WriteLine($"值在0-100之间");
            }
            else
            {
                base._StepBase.InvokeHandle(stepContext);
            }
        }
    }
}
