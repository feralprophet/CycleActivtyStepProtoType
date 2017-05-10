using CycleActivtyStepProtoType.Activity;
using CycleActivtyStepProtoType.Enum;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Builders
{
    public interface IActivityBuilder
    {
        ICycleActivity Build();

        IActivityBuilder ActivityType(CycleActivityType activityType);

        IInitialStepBuilder RunInitialStep<T>() where T:IStep;
    }
}
