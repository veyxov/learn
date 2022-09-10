use std::io;
use std::cmp;

fn greet() {
    println!("Hello, welcome to the guessing game !");
}

fn get_user_input() -> i32 {
    let mut buffer = String::new();

    io::stdin()
        .read_line(&mut buffer)
        .expect("Please provide a number");

    return buffer.trim().parse().expect("Cannot parse to int");
}

fn main() {
    greet();
    let secret = 
    loop {
        println!("Please guess a number: ");
        let result = get_user_input();

    }
}
