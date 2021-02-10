#ifndef PERSON_H
#define PERSON_H

#include<string>
using namespace std;

class Person
{
//public constructor
public:
	Person();
	virtual ~Person(); // destruktor

	bool SetName(const string nameToSet);
	string GetName() const;

	bool SetAge(const unsigned int ageToSet);
	unsigned int GetAge() const;

	virtual void Walk();

private: 
	string m_Name;
	unsigned int m_Age;
};
#endif
