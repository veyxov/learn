fn _borrowing() {
    let first = String::from("Hello world");
    let second = first.clone();

    println!("{}", first);
    println!("{}", second);
}

fn foreach()
{
    for number in (1..10).rev() {
        println!("{number}")
    }
}

fn main() {
    foreach();
}
