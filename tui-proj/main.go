package main

import (
	"github.com/gdamore/tcell/v2"
	"github.com/rivo/tview"
)

func main() {
    app := tview.NewApplication()
	inputField := tview.NewInputField().
    SetLabel("Enter a task: ").SetFieldWidth(25)

    flex := tview.NewFlex()
    list := tview.NewList()

    flex.AddItem(list, 50, 0, false);
    flex.AddItem(inputField, 100, 1, false);

    inputField.
		SetDoneFunc(func(key tcell.Key) {
            list.AddItem(inputField.GetText(), "", '-', nil)
            inputField.SetText("")
		})

	if err := app.SetRoot(flex, true).SetFocus(inputField).Run(); err != nil {
		panic(err)
	}
}
