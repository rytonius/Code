using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefactoringGuruStrategyExample.Interfaces
{
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}


    // The Strategy interface declares operations common to all supported
    // versions of some algorithm.
    //
    // The Context uses this interface to call the algorithm defined by Concrete
    // Strategies.