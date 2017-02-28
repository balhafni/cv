#include<iostream>
#include<list>
#include<string>
#include<fstream>
using namespace std;


list<int> integer_list;
void reading() {
	string line;
	ifstream file("info.txt");
	int i;
	while (file >> i) {
		integer_list.push_front(i);
	}
}

void printingBackwards() {
	list<int>::iterator i;
	for ( i = integer_list.begin(); i != integer_list.end(); i++)
	{
		cout << *i << endl;
	}
}

void main() {
	reading();
	printingBackwards();
}