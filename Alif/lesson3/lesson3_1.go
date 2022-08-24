package main

import (
	"flag"
	"log"
	"strings"
)

const template string = "Добро пожаловать, {name}! Ваш код доступа: {number}."

func main() {
    flag.Parse()

    var name string = flag.Arg(0)
    var number string = flag.Arg(1)

    if (name == "") {
        log.Fatal("Please provide the name.")
    }
    if (number == "") {
        log.Fatal("Please provide the number.")
    }

    var result = strings.ReplaceAll(template, "{name}", name) // Name
    result = strings.ReplaceAll(result, "{number}", number) // Number
    println(result)
}
