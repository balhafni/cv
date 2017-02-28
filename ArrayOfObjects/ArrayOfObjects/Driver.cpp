#include<string>
#include<iostream>
#include "Person.h"


using namespace std;


const int NUMBER_OF_PEOPLE = 4;

int main() {


	Person people[4];
	string name; int age;
	for (int i = 0; i < NUMBER_OF_PEOPLE; i++) //filling the array 
	{
		cout << "Input the " << i + 1 << " Person name :";
		cin >> name;
		cout << "Input the " << i + 1 << " Person age: ";
		cin >> age;
		people[i].set_values(name, age);


	}
	cout << "The array has the following: " << endl;
	for (int i = 0; i < NUMBER_OF_PEOPLE; i++) // printing out the array
	{
		cout << "The name of the " << i + 1 << " person is " << people[i].get_name() << "and has an age of " << people[i].get_age() << endl;
	}

	system("PAUSE");

	return 0;
}


