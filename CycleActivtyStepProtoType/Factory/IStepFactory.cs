using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleActivtyStepProtoType.Step;

namespace CycleActivtyStepProtoType.Factory
{
    public interface IStepFactory
    {
        T Create<T>() where T : IStep;
    }
}
