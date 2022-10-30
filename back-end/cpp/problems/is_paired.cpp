#include <iostream>
using namespace std;

inline bool isPairedN(int a[], int n, int len) {
    bool isPaired = false;

    // Can indecies add up to n ?
    if (n <= 0 || n > (2 * len - 3)) {
        return false;
    }

    for (int i = 0; i < len; ++i) {
        for (int j = i + 1; j < len; ++j) {
            if (a[i] + a[j] == n && i + j == n) {
                return true;
            }
        }
    }

    // Answer not found.
    return false;
}

int main() {
    int a1[] = {1, 4, 1, 4, 5, 6};
    int a2[] = {0, 1, 2, 3, 4, 5, 6, 7, 8};
    int a3[] = {1, 4, 1};
    int a4[] = {8, 8, 8, 8, 7, 7, 7};
    int a5[] = {8, -8, 8, 8, 7, 7, -7};
    int a6[] = {3};
    int a7[] = {};

    cout << isPairedN(a1, 5, 6) << '\n';
    cout << isPairedN(a1, 6, 6) << '\n';
    cout << isPairedN(a2, 6, 9) << '\n';
    cout << isPairedN(a3, 5, 3) << '\n';
    cout << isPairedN(a4, 15, 7) << '\n';
    cout << isPairedN(a5, -15, 7) << '\n';
    cout << isPairedN(a6, 3, 1) << '\n';
    cout << isPairedN(a7, 0, 0) << '\n';
}
