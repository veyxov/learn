use std::io::stdin;

pub(crate) fn get_user_input() -> String  {
    let mut input_string = String::new();

    stdin().read_line(&mut input_string).expect("Failed to read line");

    return input_string;
}

