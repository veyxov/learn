package commission

const limit = 5000 * 100

func Calculate(amount int64) int64 {
    var res int64

    if (amount <= limit) {
        res = amount;
    } else {
        res = (amount / 2) / 100

        // Mininum commission is 25 dirams.
        if (res <= 25) {
            res = 25
        }
    }
    return res;
}
