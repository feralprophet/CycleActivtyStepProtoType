using CycleActivtyStepProtoType.Enum;

namespace CycleActivtyStepProtoType.Activity
{
    public class CycleActivity : ICycleActivity
    {
      
        public IActivityStep InitialStep { get; }
        public CycleActivityType ActivityType { get; }

        public void Run()
        {
            //todo: add logging
            if (InitialStep != null)
            {
                InitialStep.Execute();
            }
        }

        public CycleActivity(IActivityStep initialStep, CycleActivityType cycleActivityType)
        {
            InitialStep = initialStep;
            ActivityType = cycleActivityType;
        }
    }
}
