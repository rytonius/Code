using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RefactoringGuruStrategyExample.Interfaces;

namespace RefactoringGuruStrategyExample
{
    public class ConcreteStrategyB: IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            if (list is not null) {
                list.Sort();
                list.Reverse();
                return list;
            }
            return new ArgumentException("list is null", nameof(data));
            
        }
    }
}

  // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.