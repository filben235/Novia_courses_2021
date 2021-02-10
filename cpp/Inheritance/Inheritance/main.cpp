#include <iostream>
#include <string>

#include "Person.h"
#include "Employee.h"

int main() {
	//kallar på defult constructorn
	Person person1{};

	if (person1.SetName("Peter") == true) {
		cout << "The new name for person1 is " << person1.GetName() << endl;
	}
	person1.Walk();

	Employee person2{"Pekka"};
	
	if (person2.SetName("Stina") == true) {
		cout << "The new name for person2 is " << person2.GetName() << endl;
	}
	person2.Walk();

	///////////////////

	Person* thePerson = nullptr;

	//The user selects a person
	thePerson = &person1;
	thePerson->Walk();

	//The user selects another person
	thePerson = &person2;
	thePerson->Walk();
}