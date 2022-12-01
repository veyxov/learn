#include <iostream>
using namespace std;

int main() {
	int max = 0, cache = 0;
	string cur, prev;

	while (true) {
		string cur_line;
		getline(cin, cur_line);
		if (cur_line == "q") break;

		if (cur_line.empty()) {
			if (cache > max) {
				max = cache;
			}
			cache = 0;
		} else {
			int i = stoi(cur_line);

			cache += i;
		}

	}
	cout << max;
}
