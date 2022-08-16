package main

import (
	"log"
	"net/http"
)

func main() {
    http.HandleFunc("/", func(w http.ResponseWriter, r *http.Request) {
        log.Print("hello")
    })

	http.ListenAndServe(":9090", nil);
}
