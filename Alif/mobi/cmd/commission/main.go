package main

import (
    "mobi/pkg/commission"
    "fmt"
)

func main() {
    result := commission.Calculate(9_999_99)
    fmt.Println(result)
}
