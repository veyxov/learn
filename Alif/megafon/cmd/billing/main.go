package main

import (
	"fmt"
	"megafon/pkg/billing"
)
func main() {
    result := billing.Calculate1000(9999) // трафик передаётся в мегабайтах, результат должен быть в дирамах
    fmt.Println(result)
}
