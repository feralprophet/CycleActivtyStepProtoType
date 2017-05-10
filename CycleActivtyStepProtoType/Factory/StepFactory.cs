using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Step;
using Ninject;

namespace CycleActivtyStepProtoType.Factory
{
    public class StepFactory: IStepFactory
    {
        private readonly IKernel _kernel;
        public StepFactory(IKernel kernel)
        {
            if (kernel == null) throw new ArgumentNullException(nameof(kernel));
            _kernel = kernel;
        }

        public T Create<T>() where T : IStep
        {
            return _kernel.Get<T>();
        }
    }
}
