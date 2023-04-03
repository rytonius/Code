using System.Reflection;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RefactoringGuruStrategyExample.Interfaces;

namespace RefactoringGuruStrategyExample
{
    public class ConcreteStrategyDefault : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            if (data is not null) 
                return data;
            return new ArgumentException("list is null", nameof(data));
        }
    }
}

  // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.