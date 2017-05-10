using System;

namespace CycleActivtyStepProtoType.Step.TestStepOne
{
    public class TestStepOneResult : IStepResult
    {
        public bool Success { get; set; }
    }

    public class TestStepOneInput : IStepInput
    {
        public int Id { get; set; }
    }

    public class TestStepOne: StepBase<TestStepOneInput, TestStepOneResult>
    {
        public override TestStepOneResult Execute(TestStepOneInput input)
        {
            Console.WriteLine($"Running {nameof(TestStepOne)}");

            return new TestStepOneResult {Success = false};
        }
    }
}
