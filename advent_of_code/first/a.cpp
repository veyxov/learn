#include <algorithm>
#include <iostream>
#include <vector>

using namespace std;

int main() {
	int max = 0, cache = 0;
	string cur, prev;

	vector<int> tops;

	while (true) {
		string cur_line;
		getline(cin, cur_line);
		if (cur_line == "q") break;

		if (cur_line.empty()) {
			tops.push_back(cache);

			cache = 0;
		} else {
			int i = stoi(cur_line);

			cache += i;
		}

	}

	sort(tops.rbegin(), tops.rend());

	for (auto i: tops)
		cout << i  << " ";
	cout << endl;
	cout << tops[0] + tops[1] + tops[2];
}
