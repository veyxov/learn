package main;

func onlyEven(text string) (result string) {
    for i := 0; i < len(text); i++ {
        if (i % 2 == 0) {
            result = result + string(text[i]);
            }
    }
    return
}

func main() {
    print(onlyEven("arst"));
}
