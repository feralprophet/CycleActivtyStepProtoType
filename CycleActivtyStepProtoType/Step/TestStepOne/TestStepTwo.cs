using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleActivtyStepProtoType.Step.TestStepOne
{
    public class TestStepTwoResult : IStepResult
    {
        public string Message;
    }

    public class TestStepTwoInput : IStepInput
    {
        public bool WasLastSucessfull { get; set; }
    }

    public class TestStepTwo : StepBase<TestStepTwoInput, TestStepTwoResult> 
    {
        public override TestStepTwoResult Execute(TestStepTwoInput input)
        {
            Console.WriteLine($"Running ${nameof(TestStepTwo)}");
            Console.WriteLine($"value from input {input.WasLastSucessfull}");
            return new TestStepTwoResult {Message = "Woot"};
        }
    }
}
