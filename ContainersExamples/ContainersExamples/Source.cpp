#include<iostream>
#include<list>
#include<map>
#include<string>
#include<set>
using namespace std;

void setExample();
int main() {  //note that if you're using vectors, you won't be able to insert at the beginning
	setExample();
	return 0;
}

void mapExample() { //maps don't take duplicates
	map<int, string> emps;
	//we can also insert as pairs
	emps.insert(pair<int, string>(123, "David"));
	emps[100] = "Bashar";
	emps[101] = "Sarah";
	emps[102] = "Dina";
	emps[103] = "Rula";

	for (map<int, string>::iterator i = emps.begin(); i != emps.end(); i++)
	{
		cout << (*i).first << ": " << (*i).second << endl;
	}


}
void listExample() {
	list<int> l;
	l.push_back(0);
	l.push_front(0);
	l.insert(++l.begin(), 2);
	l.push_back(5);
	l.push_back(6);

	//creating an iterator
	list<int>::iterator i;
	for (i = l.begin(); i != l.end(); i++)
	{
		cout << *i << endl;
	}
}

void setExample() { //the sets also cannot accept duplicates
	//if you want to use duplicates in a list, we can use a multilist
	set<string> s;
	s.insert("Bashar");
	s.insert("Bashar");
	set<string>::iterator i;
	cout << s.size() << endl;
	for (i = s.begin(); i != s.end(); i++)
	{

	}

}



