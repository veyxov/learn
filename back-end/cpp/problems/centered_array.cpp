#include <iostream>
#include <vector>
using namespace std;

inline bool is_centered(const vector<int>& a)
{
    if (a.size() % 2 == 0 || a.size() <= 0) return 0;

    int middle = a[(int)a.size() / 2];
    bool ok = true;

    for (int i = 0; i < a.size(); ++i){
        if (i != a.size() / 2 && a[i] <= middle) {
            ok = false;
            break;
        }
    }
    return ok;
}

int main() {
    int n; cin >> n;
    vector <int> a(n);

    for (int i = 0; i < a.size(); i++) {
        cin >> a[i];
    }

    cout << is_centered(a);
}
