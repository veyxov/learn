package main

func hw1() {
	println("Hello, I am Shekhov Ismoil.\n")
	println("I work at Alif-Tech department.")
	println("I am a .NET back-end developer there.")
	println("I am found of learning new thechnologies and languages.")
}

func hw2_1() {
	const (
        girls = 3
        boysMultiplier = 2
    )

	var boys = girls * boysMultiplier
	println(boys + girls)
}

func hw2_2() {
	const (
        initialCount = 67
        dressesMade  = 8
        dressCost    = 3
	)
    println(initialCount - (dressesMade * dressCost))
}

func hw2_3() {
    const (
        polutionPower = 12 // Polution power of one liter
        thisYearPolution = 8_000_000
        yearsToCount = 3
    )

    println(polutionPower * thisYearPolution * yearsToCount)
}

func main() {
    hw1()
    hw2_1()
    hw2_2()
    hw2_3()
}
