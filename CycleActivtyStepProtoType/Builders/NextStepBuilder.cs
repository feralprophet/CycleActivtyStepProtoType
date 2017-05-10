using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Activity;
using CycleActivtyStepProtoType.Factory;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Builders
{
    public class NextStepBuilder<T> : StepBuilderBase<T> , INextStepBuilder where T: IStep
    {
       
       
        public INextStepBuilder MapPreviousOutputToInputBuilder(Func<IStepResult, IStepInput> stepMapping)
        {
            StepMapping = stepMapping;
            return this;
        }
        public NextStepBuilder(IStepFactory stepFactory) : base(stepFactory)
        {
        }
    }
}
