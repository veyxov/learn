package main

import (
	"flag"
	"fmt"
	"strings"
)

func main() {
    flag.Parse()

    number := flag.Arg(0)
    trimmed := strings.ReplaceAll(number, " ", "") // Space
    trimmed = strings.ReplaceAll(trimmed, "(", "") // (
    trimmed = strings.ReplaceAll(trimmed, ")", "") // )
    trimmed = strings.ReplaceAll(trimmed, "-", "") // -

    fmt.Println(trimmed)
}
