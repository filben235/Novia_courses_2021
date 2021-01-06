#include <iostream>
#include <string>
#include <ios> 
#include <limits>

using namespace std;

int main() {
	int number;
	cout << "Enter a number to get the multiplication table of it: ";
	cin >> number;
	cin.ignore(numeric_limits<streamsize>::max(), '\n');

	for (int i = 1; i <= 10; ++i) {
		cout << number * i << "\n";
	}

	system("pause");
	return 0;
}