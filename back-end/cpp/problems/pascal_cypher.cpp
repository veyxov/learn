#include <iostream>
#include <vector>
using namespace std;

string cypher(string s) {
    string result = "";
    vector<int> cyphers;

    for (int n = 1; n <= s.size(); n++){
        int val = 1;
        for (int r = 1; r <= n; r++){
            cout << val << "   ";
            cyphers.push_back(val);

            val = val * (n - r)/r;
        }
        cout<<endl;
    }
}

int main() {
    string s;
    cin >> s;

    cout << solve(s);
}
