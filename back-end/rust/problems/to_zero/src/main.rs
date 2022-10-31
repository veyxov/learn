pub fn number_of_steps(n: i32) -> i32 {
    let mut num = n;
    let mut count = 0;

    while num > 0 {
        count += 1;

        if num % 2 == 0 {
            num /= 2;
        } else {
            num -= 1;
        }
    }

    return count;
}

fn main() {
    print!("{}", number_of_steps(8));
}
