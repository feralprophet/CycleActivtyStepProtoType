using System;
using CycleActivtyStepProtoType.Activity;
using CycleActivtyStepProtoType.Factory;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Builders
{
    public abstract class StepBuilderBase<T>:
        IStepBuilder<T>
        where T: IStep
    {
        protected Func<IStepResult, IStepInput> StepMapping;
        protected readonly IStepFactory StepFactory;
        private INextStepBuilder _nextStepBuilder;
        protected Type StepType => typeof (T);

        protected StepBuilderBase( IStepFactory stepFactory)
        {
           
            if (stepFactory == null) throw new ArgumentNullException(nameof(stepFactory));
            StepFactory = stepFactory;
        }

        public INextStepBuilder ThenStep<TNextStep>() where TNextStep : IStep
        {
            _nextStepBuilder = new NextStepBuilder<TNextStep>(StepFactory);
            return _nextStepBuilder;
        }

        public IActivityStep Build()
        {
            var step = StepFactory.Create<T>();
            return _nextStepBuilder == null
                ? new ActivityStep(step, StepMapping)
                : new ActivityStep(step, StepMapping, _nextStepBuilder.Build());
        }
    }
}
