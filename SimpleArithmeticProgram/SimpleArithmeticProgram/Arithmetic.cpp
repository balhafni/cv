#include<iostream>;
using namespace std;

int main() {
	const double RATE = 6.9;
	double deposit;
	double newBalance;
	cout << "Enter the amount of the deposit: $";
	cin >> deposit;
	newBalance = deposit + deposit*(RATE / 100);
	cout << "in one year that deposite will be $" << newBalance << endl;

	return 0;
}