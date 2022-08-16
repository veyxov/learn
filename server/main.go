package main

import (
	"fmt"
	"io/ioutil"
	"net/http"
)

func main() {
    http.HandleFunc("/", func(w http.ResponseWriter, r *http.Request) {
        // Get data from body
        all, err := ioutil.ReadAll(r.Body);
        if err != nil {
            http.Error(w, "Error occured.", http.StatusBadRequest)
        }

        // Print it back to the response.
        fmt.Fprintf(w, "body: %s", all)
    })

	http.ListenAndServe(":9090", nil);
}
