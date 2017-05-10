using System;
using System.Collections.Generic;
using CycleActivtyStepProtoType.Activity;
using CycleActivtyStepProtoType.Factory;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Builders
{
    public class InitialStepBuilder<T>: StepBuilderBase<T>, IInitialStepBuilder where T : IStep
    {
        public IInitialStepBuilder WithInitialStepInput(Func<IStepInput> initialInputs)
        {
            StepMapping = result => initialInputs.Invoke();
            return this;
        }
        public InitialStepBuilder(IStepFactory stepFactory) : base(stepFactory)
        {
        }

    
    }
}
