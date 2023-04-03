using static System.Console;
using Statements;

public abstract class Shape { }
public class Square : Shape {
    public double Side {get;set;}
}
public class Circle : Shape {
    public double Radius {get;set;}
}
public class Triangle : Shape {
    public double Height {get;set;}
}
public class Red : Shape {
    public double Color {get;set;}
}

class Program { // switch statements
    static void Main() {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(){Side = 5});
        shapes.Add(new Square(){Side = 15});
        shapes.Add(new Circle(){Radius = 7});
        shapes.Add(new Triangle(){Height = 5});

        Square nullSquare = (Square)null;
        shapes.Add(nullSquare);

        shapes.Add(new Red(){Color = 255});
        shapes.Add(new Triangle(){Height = 13}); // you wont ever see this one, since default triggers on the above line
        

        foreach (Shape shape in shapes) {
            switch (shape) {
                case Circle circle: 
                    WriteLine($"Shape is a Circle of radius {circle.Radius}");
                    break;
                case Square square when square.Side > 10: 
                    WriteLine($"Shape is a large Square side of {square.Side}");
                    break;
                case Square square: 
                    WriteLine($"Shape is a Square dimensions of {square.Side} * {square.Side} = {square.Side * square.Side}");
                    break;
                case Triangle triangle: 
                    WriteLine($"Shape is a Triange with a height of {triangle.Height}");
                    break;
                case null:
                    WriteLine("Shape is null");
                    break;
                default:
                    WriteLine("shape is not a recognized shape"); break;
                    // throw new ArgumentException(message: "shape is not a recognized shape",
                    // paramName: nameof(shape)); // Have to comment these lines out to continue
            }
        }

        WriteLine("\nContinueStatement");
        ContinueStatement.Method();      
    
        WriteLine("\nUsingStatement");
        UsingStatement.Method();
    }
}