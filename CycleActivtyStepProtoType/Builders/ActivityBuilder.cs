using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Activity;
using CycleActivtyStepProtoType.Enum;
using CycleActivtyStepProtoType.Factory;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Builders
{
    public class ActivityBuilder : IActivityBuilder
    {
        private readonly IStepFactory _stepFactory;
        private IInitialStepBuilder _initialStepBuilder;
        private CycleActivityType _activityType;
        public ActivityBuilder(IStepFactory stepFactory)
        {
            if (stepFactory == null) throw new ArgumentNullException(nameof(stepFactory));
            _stepFactory = stepFactory;
        }

        internal void Run(INextStepBuilder initialStepBuilder)
        {
            throw new NotImplementedException();
        }

        public ICycleActivity Build()
        {
            var iniStep = _initialStepBuilder.Build();
            return new CycleActivity(iniStep, _activityType);
        }

        public IActivityBuilder ActivityType(CycleActivityType activityType)
        {
            _activityType = activityType;
            return this;
        }


        public IInitialStepBuilder RunInitialStep<T>() where T: IStep
        {
            _initialStepBuilder = new InitialStepBuilder<T>(_stepFactory);
            return _initialStepBuilder;
        }
    }
}
