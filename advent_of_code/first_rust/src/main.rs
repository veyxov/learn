use std::fs::File;
use std::io::{self, BufRead};
use std::path::Path;

fn main() {
    const FILE_PATH: &str = "input.txt";

    if let Ok(lines) = read_lines(FILE_PATH) {
        // Consumes the iterator, returns an (Optional) String
        for line in lines {
            if let Ok(ip) = line {
                println!("{}", ip);
            } else {
                println!("Some error occured while reading file");
            }
        }
    }
}

// The output is wrapped in a Result to allow matching on errors
// Returns an Iterator to the Reader of the lines of the file.
fn read_lines<P>(filename: P) -> io::Result<io::Lines<io::BufReader<File>>>
where P: AsRef<Path>, {
    let file = File::open(filename)?;
    Ok(io::BufReader::new(file).lines())
}
