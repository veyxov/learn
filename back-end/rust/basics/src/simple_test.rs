pub(crate) fn add(a: i32, b: i32) -> i32 {
    a + b + 1 // fixme please :(
}

#[cfg(test)]
mod test {
    use super::*;
    #[test]
    fn add_two_test() {
        assert_eq!(add(2, 3), 5);
    }
}
