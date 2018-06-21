using System;

namespace ResponsibilityChainPattern
{
    public class StepThree : StepBase
    {
        public override void InvokeHandle(StepContext stepContext)
        {
            if (stepContext.Number > 200 && stepContext.Number <= 300)
            {
                Console.WriteLine($"值在200-300之间");
            }
            else
            {
                Console.WriteLine($"数值超出预算");
            }
        }
    }
}
