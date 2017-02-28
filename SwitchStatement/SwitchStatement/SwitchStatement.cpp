#include<iostream>;
#include<string>;
using namespace std;

int main() {

	int vehicleClass;
	double toll;
	cout << "Enter vehicle class";
	cin >> vehicleClass;
	switch (vehicleClass)
	{
	case 1:
		cout << "Passenger car." << endl;
		toll = 0.50;
		break;
	case 2:
		cout << "Bus." << endl;
		toll = 1.50;
		break;
	case 3:
		cout << "Truck" << endl;
		toll = 2.00;
		break;
	default:
		cout << "Uknown Vehicle class" << endl;
		break;
	}
	return 0;
}