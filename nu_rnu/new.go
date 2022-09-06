package main

import "flag"

func main() {
    path_instance := flag.String("path", "default", "The file path")
    flag.Parse()

    path := *path_instance

    println(path)
}
