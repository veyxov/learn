fn str_replace(s: &String, source: char, dest: char) -> String {
    let mut new_str = String::new();

    for ch in s.chars() {
        if ch == source {
            new_str.push(dest);
        } else {
            new_str.push(ch);
        }
    }

    new_str
}

fn main() {
    let s = String::from("Ismoil");
    let res = str_replace(&s, 'I', 'A');
    println!("First str: {}\nNew str: {}", s, res);
}
