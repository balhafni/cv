#include <iostream>;
#include "Header.h";

using namespace std;





void main() {
	int num;
	cout << "Please input an integer!";
	cin >> num;
	cout << "The factorial of " << num << "is " << factorial(num);
	system("PAUSE");
}



int add(int n1, int n2) {
	int result = n1 + n2;
	return result;
}


int factorial(int num) {
	if (num == 0) {
		return 1;
	}
	return num * factorial(num - 1);
}
