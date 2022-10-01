struct Person {
    name: String,
    age: u8
}

fn main() {
    let ismoil = Person { name: "Ismoil".to_string(), age: 16 };

    println!("{} {}", ismoil.name, ismoil.age);
}
