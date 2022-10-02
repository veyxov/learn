use std::{env, net::IpAddr, str::FromStr};

#[derive(Debug)]
struct Arguments {
    ip: IpAddr,
    thread_count: u8,
}

impl Arguments {
    fn new(ip: String, thread_count: String) -> Result<Arguments, String> {
        let ip_parsed: IpAddr = IpAddr::from_str(&ip).unwrap();
        let thread_parsed: u8 = thread_count.parse::<u8>().unwrap();

        return Ok(Arguments {
            ip: ip_parsed,
            thread_count: thread_parsed
        });
    }
}

fn main() {
    let args_list: Vec<String> = env::args().collect();

    let args = Arguments::new(args_list[1].clone(), args_list[2].clone()).unwrap();

    println!("{:?}", args);
}
