#include <string>
#include <iostream>
#include <string_view>

void askName(std::string_view str) {
	int number{};
	std::string name{};

	std::cout << "\n" << std::string_view{ str } << "\n";
	std::cout << "enter a number: "; std::cin >> number;
	std::cout << "\nWhat is your full name? "; std::getline(std::cin >> std::ws, name) ;

	std::cout << "\nYour name is " << name << ", your number: " << number << ", and length of name: " << name.length() << "\n"
		<< "now lets add your number with length of name = " << number + (int)name.length() << "\n\n";


	using namespace std::literals; // easiest way to access the s and sv suffixes

	std::cout << "foo\n";   // no suffix is a C-style string literal
	std::cout << "goo\n"s;  // s suffix is a std::string literal
	std::cout << "moo\n"sv; // sv suffix is a std::string_view literal
}


void printString(std::string str)
{
	std::cout << str << '\n';
}