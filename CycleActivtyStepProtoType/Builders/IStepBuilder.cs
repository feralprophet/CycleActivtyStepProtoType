using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Activity;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Builders
{
    public interface IStepBuilder
    {
        INextStepBuilder ThenStep<TNextStep>() where TNextStep : IStep;

        IActivityStep Build();
    }

    public interface IStepBuilder<T>: IStepBuilder 
        where T: IStep
    {
      
    }
}
