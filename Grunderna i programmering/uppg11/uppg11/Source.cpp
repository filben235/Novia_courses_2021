#include <iostream>
#include <string>
#include <ios> 
#include <limits>

using namespace std;

//checks if the number is odd or not
bool isValid(int number) {
	if ((number % 2 != 0) && (3 <= number && number <= 49)) return true;
	else return false;
}

//handles the counting up and down, plus printing
void counter(int number) {
	int i{ 1 };
	for (i; i < number; i++) {
		cout << string(i, '*') << endl;
	}
	for (i; i >= 1; i--) {
		cout << string(i, '*') << endl;
	}	
}

int main() {
	int number;
	//loops until valid number is entered
	do {
		cout << "Enter an odd number between 3 and 49: ";
		cin >> number;
		cin.ignore(numeric_limits<streamsize>::max(), '\n');
	} while (!isValid(number));
	counter(number);

	system("pause");
	return 0;
}