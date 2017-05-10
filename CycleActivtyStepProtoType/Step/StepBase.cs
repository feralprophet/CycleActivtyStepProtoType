using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleActivtyStepProtoType.Step
{
    public abstract class StepBase<TInput, TResult>:  IStep<TInput, TResult> where TResult : IStepResult where TInput : class, IStepInput
    {
        public abstract TResult Execute(TInput input);

        public IStepResult Execute(IStepInput input)
        {
            try
            {
                return Execute(input as TInput);
            }
            catch (Exception)
            {                
                throw;
            }   
        }
    }
}
