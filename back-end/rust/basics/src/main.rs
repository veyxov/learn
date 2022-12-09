struct Rect {
    // Sides of the rectangle
    a: i32,
    b: i32
}

impl Rect {
    // Calculate area:
    // S = a * b
    fn calculate_area(&self) -> i32 {
        self.a * self.b
    }

    // Calculate perimeter:
    // P = 2 * (a + b)
    fn calculate_perimeter(&self) -> i32 {
        2 * (self.a + self.b)
    }
}

fn main() {
    let rect1 = Rect {
        a: 2,
        b: 3
    };

    println!("Rectangle area: {}", rect1.calculate_area());
    println!("Rectangle perimeter: {}", rect1.calculate_perimeter());
}
