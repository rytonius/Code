using static System.Console;
using ArraysChapter;
//elements: the individual data items of an array are called elements.  
//          All elements of an array must be of the same type or derived
//          from the same type.

//Rank/dimensions: Arrays can have any positive number of dimensions.
//          The number of dimensions an array has is called its rank.

//Dimension length: Each dimension of an array has a length, 
//          which is the number of positions in that direction.

//Array length: The total number of elements contained in an array,
//          in all dimensions, is called the length of the array.

//Arrays can store value or reference types.  
// useful members, Rank, Length, GetLength, Clear, Sort, 
// BinarySearch, Clone, IndexOf, Reverse, GetUpperBound
InstantiatingAndAccess IAA = new InstantiatingAndAccess();
WriteLine("\n InstantiatingAndAccess");
IAA.InitArray();
IAA.WriteArrayValues();
IAA.PuttingItAllTogether();
IAA.JaggedArraysAreSilly();
IAA.foreachArrays();
IAA.ForeachRectangleArray(17, 18, 99, 30);
IAA.ExampleJaggedArrayForEach();
WriteLine("\n ArrayMembers\n");
ArrayMembers AM = new ArrayMembers();
AM.runit();
WriteLine("\nRefReturnRefLocalArrays\n");
RefReturnRefLocalArrays.RunIt();