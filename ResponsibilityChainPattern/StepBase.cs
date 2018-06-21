namespace ResponsibilityChainPattern
{
    public abstract class StepBase
    {
        protected StepBase _StepBase { get; set; }

        public void SetNextStep(StepBase stepBase)
        {
            _StepBase = stepBase;
        }

        public abstract void InvokeHandle(StepContext stepContext);
    }
}
