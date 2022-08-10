use std::io::stdin;

use colored::Colorize;

fn colorize(input: String) -> colored::ColoredString {
    match input.trim() {
        "green" => input.green(),
        "red" => input.red(),
        "blue" => input.blue(),
        "pink" => input.bright_magenta(),
        "purple" => input.bright_purple(),
        _ => input.black()
    }
}

fn get_user_input() -> String  {
    let mut input_string = String::new();

    stdin().read_line(&mut input_string)
        .ok()
        .expect("Failed to read line");

    return input_string;
}

fn lifetime() {
    let input = get_user_input();
    println!("{}", colorize(input));
}

fn main() {
    loop {
        lifetime();
    }
}
