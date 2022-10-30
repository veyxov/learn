#include <iostream>
using namespace std;

bool isMercurial(int a[], int len) {
    bool first=false, second=false, hadThreeAfterOne = false;

    for (int i = 0; i < len; ++i) {
        int cur = a[i];
        if (cur == 1) {
            if(hadThreeAfterOne) return false;

            if (!first)
                first = true;
            else
                second = true;
        }
        else if (cur == 3) {
            if (first) hadThreeAfterOne = true;
        }
    }

    return true;
}

int main() {
    int a1[] = {1, 2, 10, 3, 15, 1, 2, 2};
    int a2[] = {5, 2, 10, 3, 15, 1, 2, 2};
    int a3[] = {1, 2, 10, 3, 15, 16, 2, 2};
    int a4[] = {3, 2, 18, 1, 0, 3, -11, 1, 3};
    int a5[] = {2, 3, 1, 1, 18};
    int a6[] = {8, 2, 1, 1, 18, 3, 5};
    int a7[] = {3, 3, 3, 3, 3, 3};
    int a8[] = {1};
    int a9[] = {};

    cout << isMercurial(a1, 8) << '\n' ;
    cout << isMercurial(a2, 8) << '\n' ;
    cout << isMercurial(a3, 8) << '\n' ;
    cout << isMercurial(a4, 9) << '\n' ;
    cout << isMercurial(a5, 5) << '\n' ;
    cout << isMercurial(a6, 7) << '\n' ;
    cout << isMercurial(a7, 6) << '\n' ;
    cout << isMercurial(a8, 1) << '\n' ;
    cout << isMercurial(a9, 0) << '\n' ;
}
