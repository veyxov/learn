package main

import (
	"bufio"
	"log"
	"os"
)

func printFileLines(file *os.File) {
    scanner := bufio.NewScanner(file)

    for scanner.Scan() {
        println(scanner.Text())
    }
}

func main() {
    file, err := os.Open("file.txt")
    if err != nil {
        log.Fatal("Couldn't open file.")
    }
    printFileLines(file)
    defer file.Close()
}
