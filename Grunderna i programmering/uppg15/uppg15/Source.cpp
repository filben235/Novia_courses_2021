#include <iostream>
#include <string>
#include <ios>
#include <limits>
#include "Functions.h"

using namespace std;

int main() {
	int number;

	//takes input from the user
	cout << "What number of the Fibonacci series do you want to see? ";
	cin >> number;
	cin.ignore(numeric_limits<streamsize>::max(), '\n');

	cout << "The " << number << ending(number) << " number in the Fibonacci sequence is: ";
	cout << fibonacci(number);
	return 0;
}