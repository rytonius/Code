using Duck;
using static System.Console;

Duck.Prefabs.MallardDuck mallardDuck = new Duck.Prefabs.MallardDuck();

mallardDuck.display();
mallardDuck.swim();
mallardDuck.performFly();
mallardDuck.performQuack();

Duck.Prefabs.ModelDuck modelDuck = new Duck.Prefabs.ModelDuck();

modelDuck.display();
modelDuck.performFly();
modelDuck.performQuack();
modelDuck.setFlyBehavior(new FlyRocketPowered());
WriteLine("Let me put on Rockets");
modelDuck.performFly();