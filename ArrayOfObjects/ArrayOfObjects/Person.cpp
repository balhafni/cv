#include "Person.h"
#include <string>
using namespace std;


void Person::set_values(string n, int a) {
	name = n;
	age = a;
}

string Person::get_name()const {
	return name;
}

int Person::get_age()const {
	return age;
}



