#include<iostream>
using namespace std;

bool is235Array(int a[], int len) {
    int two = 0, three = 0, five = 0;
    int other = 0;

    for (int i = 0; i < len; ++i) {
        int cur = a[i];
        if (cur % 2 == 0) ++two;
        if (cur % 3 == 0) ++three;
        if (cur % 5 == 0) ++five;
        if (cur % 2 && cur % 3 && cur % 5) ++other;
    }

    return (two + three + five + other) == len;
}

int main() {
    int a[] = {2, 3, 5, 7, 11};
    int a1[] = {2, 3, 6, 7, 11};
    int a2[] = {2, 3, 4, 5, 6, 7, 8, 9, 10};
    int a3[] = {2, 4, 8, 16, 32};
    int a4[] = {3, 9, 27, 7, 1, 1, 1, 1, 1};
    int a5[] = {7, 11, 77, 49};
    int a6[] = {2};
    int a7[] = {};
    int a8[] = {7, 2, 7, 2, 7, 2, 7, 2, 3, 7, 7};


    cout << is235Array(a, 5) << '\n';
    cout << is235Array(a1, 5) << '\n';
    cout << is235Array(a2, 9) << '\n';
    cout << is235Array(a3, 5) << '\n';
    cout << is235Array(a4, 9) << '\n';
    cout << is235Array(a5, 4) << '\n';
    cout << is235Array(a6, 1) << '\n';
    cout << is235Array(a7, 0) << '\n';
    cout << is235Array(a8, 11) << '\n';
}
