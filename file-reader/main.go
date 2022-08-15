package main

import (
	"bufio"
	"fmt"
	"os"
)

func printFileLines(file *os.File) {
    scanner := bufio.NewScanner(file)

    for scanner.Scan() {
        println(scanner.Text())
    }
}

func openFile(filePath string) (*os.File, error) {
    file, err := os.Open(filePath)

    return file, err;
}

func getUserInput(prompt string) string {
    fmt.Print(prompt)

    var result string
    fmt.Scanf("%s", &result)

    return result
}

func main() {
    for {
        user_input := getUserInput("Enter cmd (1.read, 2.create, 3.delete): ")
        path := getUserInput("Enter the path: ")
        switch user_input {
            case "1": readFile(path)
            case "2": createFile(path)
            case "4": deleteFile(path)
        }
        fmt.Println()
    }
}

func deleteFile(path string) error {
    err := os.Remove(path)
    return err
}

func createFile(path string) error {
    _, err := os.Create(path)

    return err
}

func readFile(path string) {
    file, _ := openFile(path)
    defer file.Close()
    printFileLines(file)
}
