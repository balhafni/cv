#ifndef SLIP_H
#define SLIP_H
#include<string>
#include<iostream>
using namespace std;

class FedTax {
private:
	double FED_INCOME_TAX = 0.0145;
public:
	double getTaxPercent() {
		return FED_INCOME_TAX;
	}
	double getFedTax(double grossPay) {
		return grossPay * FED_INCOME_TAX;
	}
	void display(double grossPay) {
		cout << "Federal Income Tax : " << getFedTax(grossPay) << endl;
	}
};

class MedicareTax {
private:
	double MEDICARE_TAX = 0.042;
public:
	double getTaxPercent() {
		return MEDICARE_TAX;
	}
	double getMediCare(double grossPay) {
		return grossPay * MEDICARE_TAX;
	}
	void display(double grossPay) {
		cout << "Medicare : " << getMediCare(grossPay) << endl;
	}
};

class SocialTax {
private:
	double SOCIAL_SECURITY_TAX = 0.0355;
public:
	double getTaxPercent() {
		return SOCIAL_SECURITY_TAX;
	}
	double getSocialTax(double grossPay) {
		return grossPay * SOCIAL_SECURITY_TAX;
	}
	void display(double grossPay) {
		cout << "Social Security: " << getSocialTax(grossPay) << endl;
	}
};

class IncomeTax {
private:
	double INCOME_TAX = 0.028;
public:
	double getTaxPercent() {
		return INCOME_TAX;
	}
	double getIncomeTax(double grossPay) {
		return grossPay * INCOME_TAX;
	}
	void display(double grossPay) {
		cout << "income tax : " << getIncomeTax(grossPay) << endl;
	}
};


//Facade Class
class SalarySlip {
private:
	FedTax fed_tax;
	MedicareTax med_tax;
	SocialTax social_tax;
	IncomeTax income_tax;
	double grossPay;
	int hours;

public:
	SalarySlip(double salary, int h) {
		grossPay = salary;
		hours = h;
	}
	SalarySlip() {
	}

	double getNetIncome() {
		return grossPay * (1 - (fed_tax.getTaxPercent() + med_tax.getTaxPercent()+ social_tax.getTaxPercent() + income_tax.getTaxPercent()));
	}
	double getHourlyRate() {
		return grossPay / hours;
	}
	void getTaxes() {
		cout << "Salary Slip" << endl;
		cout << "salary : " << grossPay << endl;
		fed_tax.display(grossPay);
		med_tax.display(grossPay);
		social_tax.display(grossPay);
		income_tax.display(grossPay);
		cout << "net income : " << getNetIncome() << endl;
		cout << "hourly rate : " << getHourlyRate() << endl;
	}

};
#endif