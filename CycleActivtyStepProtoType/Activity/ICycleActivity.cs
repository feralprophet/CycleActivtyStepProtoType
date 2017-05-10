using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Enum;

namespace CycleActivtyStepProtoType.Activity
{
    public interface ICycleActivity
    {
        IActivityStep InitialStep { get; }
        CycleActivityType ActivityType { get; }

        void Run();
    }
}
