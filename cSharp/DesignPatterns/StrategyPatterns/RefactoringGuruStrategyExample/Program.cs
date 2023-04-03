using System.Security.AccessControl;
using RefactoringGuruStrategyExample;
using RefactoringGuruStrategyExample.Interfaces;
using static System.Console;
WriteLine();
var context = new Context();
WriteLine("Client: Strategy is set to no sorting");
context.DoSomeBusinessLogic();
WriteLine();
WriteLine("Client: Strategy is set to normal sorting.");
context.SetStrategy(new ConcreteStrategyA());
context.DoSomeBusinessLogic();

WriteLine();

WriteLine("Client: Strategy is set to reverse sorting.");
context.SetStrategy(new ConcreteStrategyB());
context.DoSomeBusinessLogic();