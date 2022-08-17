package main

import "fmt"

func solve1() {
    var x int
    fmt.Scan(&x)

    fmt.Printf("The next number for the number %d is %d.\n", x, x + 1)
    fmt.Printf("The previous number for the number %v is %v.", x, x - 1)
}

func main() {
    solve1()
}
