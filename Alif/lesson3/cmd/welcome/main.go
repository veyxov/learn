package main

import (
    "fmt"
	"flag"
	"strings"
)

const template string = "Добро пожаловать, {name}! Ваш код доступа: {number}."

func main() {
    flag.Parse()

    name := flag.Arg(0)
    number := flag.Arg(1)

    result := strings.ReplaceAll(template, "{name}", name) // Name
    result = strings.ReplaceAll(result, "{number}", number) // Number
    fmt.Println(result)
}
