using static System.Console;

// The Command interface declares a method for executing a command.
public interface ICommand
{
    void Execute();
}

// Some commands can implement simple operations on their own
class SimpleCommand : ICommand {
    private Receiver _receiver;
    private string _payload = string.Empty;
    public SimpleCommand(Receiver receiver, string payload) {
        this._receiver = receiver;
        this._payload = payload;
    }

    public void Execute() {
        WriteLine("Simple Command:"); // you could just put the payload here, don't even need the receiver
        this._receiver.DoSimple(this._payload);
    }

    public void HistoryExecute() {
        Write("History of Simple Commands:  ");
        this._receiver.DoSimple(this._payload);
    }
}

// However, some commands can delegate more complex operations to other
// objects, called "receivers."
class ComplexCommand : ICommand {
    private Receiver _receiver;
    // Context data, required for launching the receiver's methods.
    private string _a;
    private string _b;


    // Complex commands can accept one or several receiver objects along
    // with any context data via the constructor.
    public ComplexCommand(Receiver receiver, string a, string b) {
        this._receiver = receiver;
        this._a = a;
        this._b = b;
    }

    // Commands can delegate to any methods of a receiver.
    public void Execute(){
        WriteLine("ComplexCommand: ");
        this._receiver.DoSomething(this._a);
        this._receiver.DoSomethingElse(this._b);
    }

}
// The Receiver classes contain some important business logic. They know how
// to perform all kinds of operations, associated with carrying out a
// request. In fact, any class may serve as a Receiver.
class Receiver {
    
    public void DoSimple(string a) {
        WriteLine($"Receiver: simple: {a}."); 
    }
    public void DoSomething(string a) {
        WriteLine($"Receiver: string1: {a}.");    
    }
    public void DoSomethingElse(string b){
        WriteLine($"Receiver: string2: {b}.");  
    }
}
// The Invoker is associated with one or several commands. It sends a
// request to the command.
class Invoker{
    private ICommand? _onStart;
    private ICommand? _onFinish;

    List<ICommand> SimpleHistory = new List<ICommand>();
    List<ICommand> ComplexHistory = new List<ICommand>();

    // Init commands.
    public void SetOnStart(ICommand command) {
        this._onStart = command;
        SimpleHistory.Add(command);
    }

    public void SetOnFinish(ICommand command) {
        this._onFinish = command;
        ComplexHistory.Add(command);
    }


    // The Invoker does not depend on concrete command or receiver classes.
    // The Invoker passes a request to a receiver indirectly, by executing a
    // command.
    
    public void DoSomethingImportant(){
        WriteLine("\nInvoker: Doing Simple Commands!!!\n");
        if (this._onStart is ICommand) {
            this._onStart.Execute();
        }
        
        Console.WriteLine("\nInvoker: Doing Complex Commands!!!\n");
        if (this._onFinish is ICommand){
            this._onFinish.Execute();
        }
    }

    public void DoSimpleHistory() {
        WriteLine("\nWriting Simple History");
        if (SimpleHistory.Count > 0) {
            for (int i = 0; i < SimpleHistory.Count; i++) {
                SimpleHistory[i].Execute();
            }
        }
    }
}

class Program {
    static void Main(string[] args) {
        // the client code can parameterize an invoker with any commands
        Invoker invoker = new Invoker();
        Receiver receiver = new Receiver();



        bool quit = false;

        while (!quit) {
            WriteLine("\npress 1: Simple\n" +
            "press 2: Complex\n" + "press 3: for SimpleHistory\n" +
            "Anything else to quit");
            switch(ReadKey(true).Key) {
                case ConsoleKey.D1 : 
                    WriteLine("Write out a simple string::\n");
                    string? RL = ReadLine();
                    if (RL == "" || null == RL) {RL = "I'll write something instead";}
                    invoker.SetOnStart(new SimpleCommand(receiver, RL));
                    
                    break;
                case ConsoleKey.D2: 
                    WriteLine("Write out a string1");
                    string? RL1 = ReadLine();
                    if (RL1 == "" || null == RL1) {RL1 = "I'll write something instead";}
                    WriteLine("Write out a string2");
                    string? RL2 = ReadLine();
                    if (RL2 == "" || null == RL2) {RL2 = "I'll write something instead";}
                    invoker.SetOnFinish(new ComplexCommand(receiver, RL1, RL2));break;
                
                case ConsoleKey.D3:
                    invoker.DoSimpleHistory(); break;
                    
                default: 
                    WriteLine("quitting");
                    quit = true;
                    break;
                
            }
            invoker.DoSomethingImportant();
            

            
        }
        WriteLine("\n You have quit, have a good day");
    }
}