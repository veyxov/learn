pub fn maximum_wealth(accounts: Vec<Vec<i32>>) -> i32 {
    let mut max = accounts[0][0];

    for account in accounts {
        let cur_max = account.iter().sum();
        
        if cur_max > max {
            max = cur_max;
        }
    }
    return max;
}

fn main() {
    let vector = vec![vec![1,2,3],  vec![3,2,1]];
    println!("{}", maximum_wealth(vector));
}
