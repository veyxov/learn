package main

import (
	"encoding/json"
	"net/http"
)

type Todo struct {
	id          int
	text        string
	isCompleted bool
}

func main() {

	// Fake repository
	todos := [1]Todo{{1, "arst", true}}

	http.HandleFunc("/todos", func(w http.ResponseWriter, r *http.Request) {
		json, err := json.Marshal(todos)
        if err != nil {
            http.Error(w, "Something happened", http.StatusInternalServerError)
        }
		// Print it back to the response.
		w.Write(json)
	})

	http.HandleFunc("/create", func(w http.ResponseWriter, r *http.Request) {
	})


	http.ListenAndServe(":9090", nil)
}
