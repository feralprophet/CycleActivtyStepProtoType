using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Builders
{
    public interface IInitialStepBuilder : IStepBuilder

    {
        IInitialStepBuilder WithInitialStepInput(Func<IStepInput> initialInputs);
    }
}
