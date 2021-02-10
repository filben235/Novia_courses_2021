#include <iostream>
#include <string>
using namespace std;

#include "Record.h"

bool FillinRecord(Record& rTheRecord)
{
	cout << "Please give the title of the book. ('Quit' to exit): ";
	getline(cin, rTheRecord.title);

	if (rTheRecord.title == string("Quit")) {
		return false;
	}
	else {
		cout << "Please give the grade (0-10): ";
		cin >> rTheRecord.score;
		//cin stream error
		if (!cin) {
			return false;
		}
		//empties cin pipe
		cin.get();
		return true;
	}
}

bool ShowRecord(Record& rTheRecord)
{
	cout << "The book's title is: " << rTheRecord.title << ".\n";
	cout << "The book's grade is: " << rTheRecord.score << "\n";
	return false;
}

