#include "stdafx.h"
#include <iostream>
#include <istream>
#include <string.h>
using namespace std;

#pragma region 声明
template <typename T> int binSearch(T *a, int n, T key);
void cal_num(char *str,int count[]);
void trans_num(int val, int mod);
#pragma endregion

int main()
{
	// arr[] = { 1,2,3,4,5 };
	//cout << binSearch(arr, 5, 3) << endl;

	/*char str[5] = { '1','2','s','d','5' };
	int count[3];
	memset(count, 0, 3*sizeof(int));
	cal_num(str, count);
	for each (int c in count)
	{
		cout << c << endl;
	}*/

	/*int n, d;
	cout << "input:" << endl;
	cin >> n >> d;
	trans_num(n, d);
	system("pause");*/
	
	MyClass s = NULL;
	
	system("pause");
	return 0;
}
class MyClass
{
public:
	MyClass();
	~MyClass();

private:

};

MyClass::MyClass()
{
}

MyClass::~MyClass()
{
}

int flag = 1;
//进制转换
void trans_num(int val, int d) {
	int mod = val % d;
	val = val / d;
	while (flag && val) {
		trans_num(val, d);
	}
	flag = 0;
	switch (mod)
	{
	case 10:
		cout << "A";
		break;
	case 11:
		cout << "B";
		break;
	case 12:
		cout << "C";
		break;
	case 13:
		cout << "D";
		break;
	case 14:
		cout << "E";
		break;
	case 15:
		cout << "F";
		break;
	default:
		cout << mod;
		break;
	}
}

//统计函数
void cal_num(char *str, int count[])
{
	char *ptr = str;
	while (*ptr) {
		if (*ptr >= '0' && *ptr <= '9')
			count[0] ++;
		else if (*ptr >= 'a' && *ptr <= 'z')
			count[1] ++;
		else
			count[2] ++;
		ptr++;
	}
}

//二分查找
template <typename T> int binSearch(T *a, int n, T key) {
	int low = 0, high = n - 1, mid;
	while (low < high)
	{
		mid = (low + high) / 2;
		if (a[mid] == key) {
			return mid;
		}
		if (key > a[mid])
			low = mid + 1;
		else
			high = mid - 1;
	}
	return -1;
}


