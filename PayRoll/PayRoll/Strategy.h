#ifndef STRATEGY_H
#define STRATEGY_H
#include<string>
#include<iostream>
#include"MainFunction.h"
using namespace std;

class Strategy {
public:
	virtual void operation() = 0;
};

class Operation_add : public Strategy
{
public:
	virtual void operation() {
		add();
	}
};

class Operation_delete : public Strategy
{
public:
	virtual void operation() {
		int ssn;
		cout << "Enter the ssn of the emp who you want to be delete: ";
		cin >> ssn;
		if (error()) return;
		deleteEmp(ssn);
	}
};

class Operation_search : public Strategy
{
public:
	virtual void operation() {
		int ssn;
		int found;
		cout << "Enter the ssn of the emp who you want to be found: ";
		cin >> ssn;
		if (error()) return;
		found = searchEmp(ssn);
		if (found == -1) {
			cout << "Opps!, Not Found!" << endl;
		}
		else {
			emps.at(found).display();
		}
	}
};

class Operation_display : public Strategy
{
public:
	virtual void operation() {
		display();
	}
};

class Operation_modify : public Strategy
{
public:
	virtual void operation() {
		int ssn;
		cout << "Enter the ssn of the emp who you want to be found: ";
		cin >> ssn;
		if (error()) return;
		modifyEmp(ssn);
	}
};


class Operation_slip : public Strategy
{
public:
	virtual void operation() {
		int ssn;
		int found;
		cout << "Enter the ssn of the emp who you want to see his/her slip: ";
		cin >> ssn;
		if (error()) return;
		found = searchEmp(ssn);
		if (found == -1) {
			cout << "Opps!, Not Found!" << endl;
		}
		else {
			emps.at(found).getSlip().getTaxes();
		}
	}
};

class Context
{
private:
	Strategy *strategy;

public:
	Context() {};
	void setStrategy(Strategy *which)
	{
		strategy = which;
	}

	void operation()
	{
		strategy->operation();
	}
};

#endif