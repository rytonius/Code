// learnccpCH4.cpp : This file contains the 'main' function. Program execution begins and ends there.
// https://en.cppreference.com/w/cpp/io/manip

#include <string>
#include <iterator>
#include <iostream>
#include <algorithm>
#include <array>
#include <iomanip>

float GetPrecision(float x) {

    int y = 12;
    
    std::cout << std::setprecision(y);
    std::cout << "\n" << "std::setprecision(" << y << ") \n" << x << "\n";
        

    return x;
}



void TrueNfalse(bool x, bool y, bool z) {
    std::cout << "\n\n";
    
    std::cout << std::boolalpha; //true and false instead of 0 and 1
    std::cout << "x: " << x << std::endl;
    std::cout << "y: " << y << std::endl;
    std::cout << "z: " << z << std::endl;

    std::cout << "x && y: " << (x && y) << std::endl;
    std::cout << "x || y: " << (x || y) << std::endl;
    std::cout << "x && y && z: " << (x && y && z) << std::endl;
    std::cout << "x || y || z: " << (x || y || z) << std::endl;
    std::cout << "x && y || z: " << (x && y || z) << std::endl;

    std::cout << "\n\n";
}

void ExampleConstantExpression() {
    // constant expressions evalutated at compile time.  Normally these can be evalutated at run time instead if it's not constant.
    constexpr int maxStudentsPerClass{ 30 };
    
}

void StringExample() {

    std::cout << "Enter your full name: ";
    std::string name{}; // empty string
    std::cin >> name;
     
}

void passtime() {
    std::cout << "passtime method starting: " << std::endl;

}



int main()
{
    // construction uses aggregate initialization
    std::array<int, 3> a1{ {1, 2, 3} }; // double-braces required in C++11 prior to
                                        // the CWG 1270 revision (not needed in C++11
                                        // after the revision and in C++14 and beyond)

    std::array<int, 3> a2 = { 1, 2, 3 };  // double braces never required after =

    std::array<std::string, 2> a3 = { std::string("a"), "b" };

    // container operations are supported
    std::sort(a1.begin(), a1.end());
    std::reverse_copy(a2.begin(), a2.end(),
        std::ostream_iterator<int>(std::cout, " "));

    std::cout << '\n';

    // ranged for loop is supported
    for (const auto& s : a3)
        std::cout << s << ' ';

    // moving on
    double avogadro{ 6.02e23 }; //scientific notation example
    std::cout << "\n" << avogadro << "\n";

    
    

    TrueNfalse(0, 1, 0);
    TrueNfalse(true, true, false);
    TrueNfalse(1, 1, 1);

    GetPrecision(9.12345678901234567890f);
    GetPrecision(334.12345678901234567890f);


    std::cout <<"\n Now for something Inacurate, this value f = 123456789.0 but see how it's displayed";

    float f{ 123456789.0f }; // has 10 digits
    std::cout << "\n full float value: " << f << "\n";
    int y = 8;
    std::cout << std::setprecision(y); // only show 9
    std::cout << "\n" << "std::setprecision(" << y << ") \n";
    std::cout << f << "\n";
    std::cout << "the number was rounded since set precision was less that total digits of the value";

    ExampleConstantExpression();

    StringExample();
}



// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file


/*
Name	Symbol	Meaning
Alert	\a	Makes an alert, such as a beep
Backspace	\b	Moves the cursor back one space
Formfeed	\f	Moves the cursor to next logical page
Newline	\n	Moves cursor to next line
Carriage return	\r	Moves cursor to beginning of line
Horizontal tab	\t	Prints a horizontal tab
Vertical tab	\v	Prints a vertical tab
Single quote	\’	Prints a single quote
Double quote	\”	Prints a double quote
Backslash	\\	Prints a backslash.
Question mark	\?	Prints a question mark.
No longer relevant. You can use question marks unescaped.
Octal number	\(number)	Translates into char represented by octal
Hex number	\x(number)	Translates into char represented by hex number
*/