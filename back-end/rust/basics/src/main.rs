fn can_be_null(shoud_be_null: bool) -> Option<i32> {
    if shoud_be_null {
        return None
    }

    return Some(112)
}

fn main() {
    println!("{:?}", can_be_null(false));
    println!("{:?}", can_be_null(true));
}
