using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleActivtyStepProtoType.Step
{
    public interface IStep
    {
        IStepResult Execute(IStepInput input);
    }

    public interface IStep<in TInput, out TOutput> : IStep 
        where TInput : IStepInput 
        where TOutput : IStepResult 
        
    {
        TOutput Execute(TInput input);
    }
}
