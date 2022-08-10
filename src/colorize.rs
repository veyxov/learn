use colored::Colorize;
pub(crate) fn colorize(input: String) -> colored::ColoredString {
    match input.trim() {
        "green" => input.green(),
        "red" => input.red(),
        "blue" => input.blue(),
        "pink" => input.bright_magenta(),
        "purple" => input.bright_purple(),
        _ => input.black()
    }
}

