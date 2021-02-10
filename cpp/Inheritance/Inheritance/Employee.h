#ifndef EMPLOYEE_H
#define EMPLOYEE_H

#include "Person.h"

class Employee : public Person
{
public:
	Employee(const string name);
	virtual ~Employee();

	//overloadar walk-funktionen
	virtual void Walk();
};

#endif

