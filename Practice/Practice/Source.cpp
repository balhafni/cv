#include<string>
#include<iostream>
using namespace std;


void main() {
	string name;
	cout << "Please input your name " << endl;
	getline(cin,name);
	cout << "HELLO " << name << endl;
	cout << name.length() << endl;

}