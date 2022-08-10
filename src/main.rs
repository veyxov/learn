use crate::colorize::colorize;

mod colorize;
mod user_input;

fn lifetime() {
    let input = user_input::get_user_input();
    println!("{}", colorize(input));
}

fn main() {
    loop {
        lifetime();
    }
}
