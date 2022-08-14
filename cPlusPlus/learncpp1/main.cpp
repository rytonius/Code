#include <iostream>

using namespace std;

void writesomething(string z)
{
	cout << "\n" << z << endl;
}

int getinput(){
	cout << "Type in int input:  ";
	int cute{};
	cin >> cute; cout << "\n";

	return cute;
}

int main()
{
	int x{5}, y{};
	// endl flushes the output then gives new line
    cout << "Hello world!\n" << "x equals: " << x << endl << "does this work\n\n";
    cout << "Hey type number: "; cin >> y; cout << "\n" << "you typed: " << y << endl;

    cout << "Double " << y << " is: " << y * 2 << '\n';
	cout << "Triple " << y << " is: " << y * 3 << '\n';

	writesomething("howdy");
	cout << "\n\n";

	int num { getinput() };

	cout << num << " doubled is: " <<  num * 2 << "\n";

    return 0;
}


