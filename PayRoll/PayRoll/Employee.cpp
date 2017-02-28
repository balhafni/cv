#include "Employee.h"
#include "Slip.h"
using namespace std;


Employee::Employee(int s, string n, string gender, double money, string date, string loc, int hrs) {
	ssn = s;
	name = n;
	sex = gender;
	salary = money;
	bdate = date;
	address = loc;
	hours = hrs;
	salarySlip = SalarySlip(salary, hours);
}
void Employee::setSsn(int social) {
	ssn = social;
}
void Employee::setName(string n) {
	name = n;
}
void Employee::setSex(string gender) {
	sex = gender;
}
void Employee::setSalary(double money) {
	salary = money;
}
void Employee::setBirthDate(string date) {
	bdate = date;
}
void Employee::setAddress(string loc) {
	address = loc;
}
int Employee::getSsn() {
	return ssn;
}
string Employee::getName() {
	return name;
}
string Employee::getGender() {
	return sex;
}
double Employee::getSalary() {
	return salary;
}
string Employee::getBdate() {
	return bdate;
}
string Employee::getAddress() {
	return address;
}

SalarySlip Employee::getSlip() {
	return salarySlip;
}

void Employee::setSlip(SalarySlip ss) {
	salarySlip = ss;
}

int Employee::getHours() {
	return hours;
}
void Employee::setHours(int hrs) {
	hours = hrs;
}
void Employee::display() {
	cout << "social: " << ssn << endl;
	cout << "name: " << name << endl;
	cout << "sex: " << sex << endl;
	cout << "salary: " << salary << endl;
	cout << "birthdate: " << bdate << endl;
	cout << "address: " << address << endl;
	cout << "hours: " << hours << endl;
}