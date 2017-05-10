using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Activity
{
    public class ActivityStep : IActivityStep
    {
        public IStep Step { get; }
        public Func<IStepResult, IStepInput> StepMapping { get; }
        public void Execute(IStepResult lastStepResult)
        {
            IStepInput input = null;

            if (lastStepResult != null && StepMapping != null)
            {
                input = StepMapping.Invoke(lastStepResult);
            }
            var result = Step.Execute(input);
            NextStep?.Execute(result);
        }
        public IActivityStep NextStep { get; }

        public void Execute()
        {
            Execute(null);
        }
        public ActivityStep(IStep step, Func<IStepResult, IStepInput> stepMapping, IActivityStep nextStep)
        {
            Step = step;
            NextStep = nextStep;
            StepMapping = stepMapping;
        }

        public ActivityStep(IStep step, Func<IStepResult, IStepInput> stepMapping)
        {
            Step = step;
            NextStep = null;
            StepMapping = stepMapping;
        }
    }
}
