fn can_fail(num: i64) -> Result<i64, String> {
    if num < 0 {
        return Err("Negative value provided".to_owned());
    }

    return Ok(num + 1);
}

fn main() {
    let result = can_fail(7);
    let result2 = can_fail(-1);

    println!("{}", result.unwrap_or(0));
    println!("{}", result2.unwrap_or_default());
}
