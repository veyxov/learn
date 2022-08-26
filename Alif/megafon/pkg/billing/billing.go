package billing

func Calculate1000(spent int) int {
    res := 35 * 100
    spent -= 1000

    if (spent > 0) {
        res += spent * 6
    }

    return res
}

func Calculate2000(spent int) int {
    res := 55 * 100
    spent -= 2000

    if (spent > 0) {
        res += spent * 6
    }

    return res
}

func Calculate3000(spent int) int {
    res := 70 * 100
    spent -= 3000

    if (spent > 0) {
        res += spent * 6
    }

    return res
}

func Calculate4000(spent int) int {
    res := 95 * 100
    spent -= 4000

    if (spent > 0) {
        res += spent * 6
    }

    return res
}

func Calculate5000(spent int) int {
    res := 170 * 100
    spent -= 5000

    if (spent > 0) {
        res += spent * 6
    }

    return res
}
