using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Activity
{
    public interface IActivityStep
    {
        IStep Step { get; }

        Func<IStepResult, IStepInput> StepMapping { get; }

        void Execute(IStepResult lastStepResult);
        void Execute();

    }
}
