using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RefactoringGuruStrategyExample.Interfaces;
using static System.Console;

namespace RefactoringGuruStrategyExample
{
    public class Context
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private IStrategy _strategy;

        public Context() {
            this._strategy = (new ConcreteStrategyDefault());
        }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public Context(IStrategy strategy) => this._strategy = strategy;


        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IStrategy strategy) => this._strategy = strategy;


        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void DoSomeBusinessLogic(){
            WriteLine("Context: Sorting data using the strategy: " + _strategy.GetType().Name);
            object result = this._strategy.DoAlgorithm(new List<string> {"Abbot", "Betta", "Delta", "Cat", "Zebra"});

            string resultStr = string.Empty;
            foreach (string element in result as List<string>) 
                resultStr += element + ", ";
            resultStr = resultStr.Remove(resultStr.Length - 2);
            WriteLine(resultStr);
        }

    }
}