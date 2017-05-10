using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Builders;
using CycleActivtyStepProtoType.Step;
using CycleActivtyStepProtoType.Step.TestStepOne;

namespace CycleActivtyStepProtoType.Factory
{
    public interface IStepBuilderFactory
    {
        IStepBuilder<TStep> Create<TStepBuilder, TStep>()
            where TStep : IStep
            where TStepBuilder : IStepBuilder<TStep>;

        //TStepBuilder<TStep> Create<TStepBuilder<TStep>>() where TStepBuilder : IStepBuilder<T> where<T>  TStep : IStep;
    }
}
