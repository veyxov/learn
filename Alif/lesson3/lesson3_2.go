package main

import (
	"flag"
	"log"
	"strings"
)

func main() {
    flag.Parse()

    var number string = flag.Arg(0)
    if number == "" {
        log.Fatal("Please provide a number.")
    }

    var sb strings.Builder

    sb.WriteRune('+')
    for _, char := range number {
        if (char >= '0' && char <= '9') {
            sb.WriteRune(char)
        }
    }

    var result = sb.String()

    println(result)
}
