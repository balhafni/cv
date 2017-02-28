#include"Employee.h"
#include"MainFunction.h"
#include"Iterator.h"
#include<fstream>
#include<iostream>
#include<vector>
#include<sstream>
#include<string>
#include<iomanip>

/* Authors: Guksung An, Bashar Alhafni, Arzeesh Zaman
Title: Payroll Management System
*/
using namespace std;
vector<Employee> emps;
vector<string> info;
ofstream outToFile;
//or constant username and password
const string  USERNAME = "user";
const string PASSWORD = "12345";
const int WIDTH = 80;

int main() {
	//changing the foregrond and the backgorund of the console
	system("color 1E");
	cout << "*****************************************" << endl;
	cout << "***   WELCOME TO THE PAYROLL SYSTEM   ***" << endl;
	cout << "*****************************************" << endl;
	login();
}
void table(string output) {
	cout << '|' << setfill(' ') << setw(5) << output
		<< endl;
	tableBorder();
}

void tableBorder() {
	cout << '+' << setfill('-') << setw(WIDTH) << '+' << endl;
}

void login() {
	string username, password;
	cout << "Enter the username: ";
	cin >> username;

	if (username.length() < 4) {
		cout << "The username must be at least 4 characters long" << endl;
		login();
	}
	else {
		cout << "Enter your passowrd: ";
		cin >> password;
		if (password.length() < 5) {
			cout << "The password must be at least 5 characters long" << endl;
			login();
		}
		else {
			if (username == USERNAME && password == PASSWORD) {
				cout << "User credentials are correct!!!" << endl;
				read();
				menu();
			}
			else {
				cout << "Invalid loging info" << endl;
				cout << "Please input the info again" << endl;
				login();

			}
		}
	}
}

void read() {
	string line;
	ifstream myfile("info.txt");
	if (myfile.is_open())
	{
		while (getline(myfile, line))
		{
			info = splitByComma(line);
			emps.push_back(Employee(stoi(info.at(0)), info.at(1), info.at(2), stod(info.at(3)), info.at(4), info.at(5), stoi(info.at(6))));

		}
		myfile.close();
	}

	else cout << "Unable to open file";

}

vector<string> splitByComma(string line) {
	vector<string> vect;
	int j = 0;
	string str = "";

	for (int i = 0; i <= line.size(); i++) {
		if (i == line.size()) {
			vect.push_back(str);
			break;
		}

		if (line.at(i) == ',') {
			vect.push_back(str);
			str = "";
		}
		else
			str += line.at(i);
	}
	return vect;

}

bool error() {
	if (cin.fail()) {
		cout << "\nThere was an error. Please retry" << endl;
		cin.clear();
		cin.ignore(1000, '\n');
		return true;
	}
	return false;
}

void add() {

	string name, sex, address, bdate;
	int ssn, hours; double salary;

	cout << "Enter the ssn of the employee that you want to add : ";
	cin >> ssn;
	if (error())
		return;
	else
		while (searchEmp(ssn) != -1) {
			cout << "That ssn already exists. Enter another ssn : ";
			cin >> ssn;
			if (error()) return;
		}
	cout << "Enter the name of the employee that you want to add : ";
	cin.ignore();
	getline(cin, name);
	cout << "Enter the sex of the employee that you want to add : ";
	cin >> sex;
	if (error()) return;
	cout << "Enter the salary of the employee that you want to add : ";
	cin >> salary;
	if (error()) return;
	cout << "Enter the birthdate of the employee that you want to add : ";
	cin >> bdate;
	if (error()) return;
	cout << "Enter the address of the employee that you want to add : ";
	cin.ignore();
	getline(cin, address);
	if (error()) return;
	cout << "Enter the hours of the employee: ";
	cin >> hours;
	if (error()) return;
	emps.push_back(Employee(ssn, name, sex, salary, bdate, address, hours));
	saveFile();
}

int searchEmp(int social) {
	for (int i = 0; i < emps.size(); i++)
	{
		if (emps.at(i).getSsn() == social) {
			return i;
		}
	}
	return -1;
}

void deleteEmp(int social) {//don't have the file open while deleting an emp
	int loc = searchEmp(social);
	if (loc == -1) {
		cout << "Emp was not found" << endl;
	}
	else {
		emps.erase(emps.begin() + loc);
		saveFile();


	}
}

void modifyEmp(int social) {
	string name, sex, address, bdate;
	double salary;
	string check;
	int hours;
	int loc = searchEmp(social);
	if (loc == -1) {
		cout << "Emp was not found" << endl;
	}
	else {


		cout << "Do you want to change the employee's name, " << emps.at(loc).getName() << "?" << endl;
		cout << "Y(yes)" << endl;
		cout << "N(no)" << endl;
		cin >> check;
		if (error()) return;
		if (check == "Y" || check == "Yes") {

			cout << "Enter the new name  : ";
			cin.ignore();
			getline(cin, name);
			emps.at(loc).setName(name);
		}

		cout << "Do you want to change the employee's sex, " << emps.at(loc).getGender() << "?" << endl;
		cout << "Y(yes)" << endl;
		cout << "N(no)" << endl;
		cin >> check;
		if (error()) return;
		if (check == "Y" || check == "Yes") {

			cout << "Enter the new sex  : ";
			cin >> sex;
			if (error()) return;
			emps.at(loc).setSex(sex);
		}

		cout << "Do you want to change the employee's salary, " << emps.at(loc).getSalary() << "?" << endl;
		cout << "Y(yes)" << endl;
		cout << "N(no)" << endl;
		cin >> check;
		if (error()) return;
		if (check == "Y" || check == "Yes") {

			cout << "Enter the  new salary  : ";
			cin >> salary;
			if (error()) return;
			emps.at(loc).setSalary(salary);
		}

		cout << "Do you want to change the employee's birthdate, " << emps.at(loc).getBdate() << "?" << endl;
		cout << "Y(yes)" << endl;
		cout << "N(no)" << endl;
		cin >> check;
		if (error()) return;
		if (check == "Y" || check == "Yes") {

			cout << "Enter the new birth date  : ";
			cin >> bdate;
			if (error()) return;
			emps.at(loc).setBirthDate(bdate);
		}

		cout << "Do you want to change the employee's address, " << emps.at(loc).getAddress() << "?" << endl;
		cout << "Y(yes)" << endl;
		cout << "N(no)" << endl;
		cin >> check;
		if (error()) return;
		if (check == "Y" || check == "Yes") {

			cout << "Enter the new address  : ";
			cin.ignore();
			getline(cin, address);
			emps.at(loc).setAddress(address);
		}
		cout << "Do you want to change the employee's hours, " << emps.at(loc).getHours() << "?" << endl;
		cout << "Y(yes)" << endl;
		cout << "N(no)" << endl;
		cin >> check;
		if (error()) return;
		if (check == "Y" || check == "Yes") {

			cout << "Enter the hours : ";
			cin >> hours;
			if (error()) return;
			emps.at(loc).setHours(hours);
		}
		saveFile();
	}
}


void display() {
	EmployeeIterator *myEmployees = new EmployeeIterator(emps);

	myEmployees->First();

	cout << "Displaying the employees: " << endl;
	while (!myEmployees->IsDone())
	{
		myEmployees->Next().display();
		cout << endl;
	}

}

void saveFile() {
	outToFile.open("info.txt", ios::trunc);
	for (int i = 0; i < emps.size(); i++)
	{
		outToFile << emps.at(i).getSsn() << "," << emps.at(i).getName() << "," << emps.at(i).getGender() << ","
			<< emps.at(i).getSalary() << "," << emps.at(i).getBdate() << "," << emps.at(i).getAddress() << ","
			<< emps.at(i).getHours() << endl;
	}
}


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


void menu() {
	int c;
	bool strategyIsSet = false;
	tableBorder();
	table("Payroll Management System");
	Operation_add add;
	Operation_delete del;
	Operation_search search;
	Operation_display display;
	Operation_modify modify;
	Operation_slip slip;
	Context context;

	do {
		cout << endl;
		table("Pick an option");
		table("1) Add an Employee");
		table("2) Delete an Employee");
		table("3) Search for an Employee");
		table("4) Display all Employees");
		table("5) Modify");
		table("6) Display Slip");
		table("7) Repeat last Operation");
		table("8) Exit");
		cin >> c;
		if (error()) return;

		switch (c) {
		case 1:
			context.setStrategy(&add);
			context.operation();
			strategyIsSet = true;
			break;
		case 2:
			context.setStrategy(&del);
			context.operation();
			strategyIsSet = true;
			break;
		case 3:
			context.setStrategy(&search);
			context.operation();
			strategyIsSet = true;
			break;
		case 4:
			context.setStrategy(&display);
			context.operation();
			strategyIsSet = true;
			break;
		case 5:
			context.setStrategy(&modify);
			context.operation();
			strategyIsSet = true;
			break;
		case 6:
			context.setStrategy(&slip);
			context.operation();
			strategyIsSet = true;
			break;
		case 7:
			if (strategyIsSet)
				context.operation();
			else
				cout << "Please select a different option first!" << endl;
			break;
		case 8:
			cout << "Thank you for using this awesome system" << endl;
			break;
		default:
			cout << "Please pick from 1 to 8" << endl;
			break;
		}
	} while (c != 8);
}
