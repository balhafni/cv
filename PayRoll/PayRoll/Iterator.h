#ifndef ITERATOR_H
#define ITERATOR_H
// Iterator Design Pattern

#include <iostream>
#include "Employee.h"
#include <vector>
using namespace std;

//Iterator
class IIterator
{
public:
	virtual void First() = 0; // Reset back to first element
	virtual Employee Next() = 0; // Get next
	virtual bool IsDone() = 0; // End of collection check
	virtual Employee CurrentItem() = 0; // Get current item
};

//Concrete IIterator
class EmployeeIterator : public IIterator
{
private:
	vector<Employee> employees;
	int position = 0;

public:
	EmployeeIterator(vector<Employee> &employees)
	{
		this->employees = employees;
		position = 0;
	}

	void First()
	{
		position = 0;
	}

	Employee Next()
	{
		return employees[position++];
	}

	bool IsDone()
	{
		return position >= employees.size();
	}

	Employee CurrentItem()
	{
		return employees[position];
	}
};

#endif
