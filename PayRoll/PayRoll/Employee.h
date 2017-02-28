#pragma once
#include<iostream>
#include <string>
#include"Slip.h"
using namespace std;
class Employee
{

private:
	int ssn;
	string name, sex;
	double salary;
	string bdate;
	string address;
	int hours;
	SalarySlip salarySlip;
public:
	Employee(int s, string n, string gender, double money, string date, string loc, int hours);
	void setSsn(int social);
	void setName(string n);
	void setSex(string gender);
	void setSalary(double money);
	void setBirthDate(string date);
	void setAddress(string loc);
	void setSlip(SalarySlip ss);
	int getSsn();
	string getName();
	string getGender();
	double getSalary();
	string getBdate();
	string getAddress();
	SalarySlip getSlip();
	int getHours();
	void setHours(int hours);
	void display();
};
