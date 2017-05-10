using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Builders;
using CycleActivtyStepProtoType.Step;
using Ninject;

namespace CycleActivtyStepProtoType.Factory
{
    public class StepBuilderFactory : IStepBuilderFactory
    {
        private readonly IKernel _kernel;

        public StepBuilderFactory(IKernel kernel)
        {
            if (kernel == null) throw new ArgumentNullException(nameof(kernel));
            _kernel = kernel;
        }

      

        IStepBuilder<TStep> IStepBuilderFactory.Create<TStepBuilder, TStep>()
        {
            return _kernel.Get<TStepBuilder>();
        }
    }
}
