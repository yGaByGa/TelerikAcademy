#include "stdafx.h"
#include <iostream>
using namespace std;

#include <iomanip>
using std::setw;

int main()
{
	int n, m, result;
	char arr[ 3 ];

	cin >> n >> m;

	for (size_t i = n; i <= m; i++)
	{
		result += i;
	}

	cout << result << endl;

    return 0;
}

