#include<iostream>
#include<string>

using namespace std;

class Animal
{
protected:
	int age;
	string name;
public:
	void setAge(int a)
	{
		(*this).age = a;
	}
	void setName(string n)
	{
		this->name = n;
	}
	int getAge() const
	{
		return age;
	}
	string getName() const
	{
		return name;
	}
};

class Dog : public Animal
{
public:
	string setBreed(string n)
	{
		return this->breed = n;
	}
	string getBreed()
	{
		return breed;
	}


private:
	string breed;
};


int main()
{
	int a;
	string n, b;
	Dog D;
	cout << "Enter the name of the Dog: ";
	cin >> n;
	cout << "Enter the age of the Dog: ";
	cin >> a;
	cout << "Enter the breed of the Dog: ";
	cin >> b;
	D.setName(n);
	D.setAge(a);
	D.setBreed(b);
	cout << "The name of the animal is: " << D.getName() << endl;
	cout << "The age of the animal is: " << D.getAge() << endl;
	cout << "Breed of the dog: " << D.getBreed() << endl;
}