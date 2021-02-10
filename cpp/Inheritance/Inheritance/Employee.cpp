#include "Employee.h"
#include <iostream>

using namespace std;

Employee::Employee(const string name) 
	:Person()
{
	SetName(name);
}

Employee::~Employee() {

}

void Employee::Walk() {
	cout << "The employee walking";
}