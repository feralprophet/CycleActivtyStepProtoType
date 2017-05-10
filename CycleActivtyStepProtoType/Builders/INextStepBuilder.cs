using System;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Builders
{
    public interface INextStepBuilder:  IStepBuilder
    {
        INextStepBuilder MapPreviousOutputToInputBuilder(Func<IStepResult, IStepInput> stepMapping);
    }
}
