package main

import (
	"bufio"
	"log"
	"os"
)

func main() {
    file, err := os.Open("file.txt")
    if err != nil {
        log.Fatal("Couldn't open file.")
    }
    defer file.Close()

    scanner := bufio.NewScanner(file)

    for scanner.Scan() {
        println(scanner.Text())
    }
}
