
using static System.Console;
 
WriteLine("{0}", 5_000_000_000);

WriteLine("\a\b\t\n\v\fform\r\"\"\'\\");

WriteLine("Va1\t5, Val2\t10");
WriteLine("Add\x000ASome\u0007Interest");

WriteLine(@"It started, ""Four score and seven..."""); //verbatim string literal

WriteLine((7f / 2f) * 4f);
WriteLine("7/2 = "+ 7 / 2 + " r" + 7 % 2 + "\n");

// logical operators and Bitwise logical operations
// binary and left-associative
const byte x = 12, y =10;

WriteLine($"x: {x} and y: {y}\n This is examples of bitwise logical operations");
WriteLine("x & y:\t {0}", x & y);
WriteLine("x | y:\t {0}", x | y);
WriteLine("x ^ y:\t {0}", x ^ y);
WriteLine("~x:\t    {0}", ~x);

sbyte neg = -12;
WriteLine(Convert.ToString(12, 2));
WriteLine(Convert.ToString(neg, 2));

WriteLine(14 << 1);
WriteLine(14 >> 1);

// conditional operator ?: 
// Condition must return a value of type bool, if true then expression1 : expression2 if false.
// condition ? expression1 : expression2

ForegroundColor = ConsoleColor.Red;
WriteLine($"\nx: {x} and y: {y}\n");
ForegroundColor = ConsoleColor.White;
WriteLine("x is {0}than y\t", x > y ? "Greater " : "Less ");
WriteLine("y is {0}than x\t", x < y ? "Greater " : "Less ");

WriteLine("\nExpressionsAndOperators.UserDefinedTypeConversions.RunIt()\n");
ExpressionsAndOperators.UserDefinedTypeConversions.RunIt();