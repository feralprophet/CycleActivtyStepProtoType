using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Builders;
using CycleActivtyStepProtoType.Factory;
using CycleActivtyStepProtoType.Step.TestStepOne;
using Ninject;

namespace CycleActivtyStepProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel =
            Bootstrap();

            var builder = kernel.Get<IActivityBuilder>();

            builder.RunInitialStep<TestStepOne>().ThenStep<TestStepTwo>().MapPreviousOutputToInputBuilder(
                (result) =>
                {
                    var conResult = (TestStepOneResult) result;

                    return new TestStepTwoInput
                    {
                        WasLastSucessfull = conResult.Success
                    };
                });

            var activity =
            builder.Build();


            activity.Run();

            Console.WriteLine("Cools");

        }

        private static IKernel Bootstrap()
        {
            var kernal = new StandardKernel();

            kernal.Bind(typeof(IInitialStepBuilder)).To(typeof(InitialStepBuilder<>));
            kernal.Bind(typeof (INextStepBuilder)).To(typeof (NextStepBuilder<>));
            kernal.Bind<IActivityBuilder>().To<ActivityBuilder>();
            kernal.Bind<IStepFactory>().To<StepFactory>();
            return kernal;
        }
    }
}
