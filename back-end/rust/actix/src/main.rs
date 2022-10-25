#[macro_use] extern crate rocket;

#[get("/")]
fn index() -> &'static str {
    "Hello world"
}

#[get("/<name>/<age>")]
fn hello(name: &str, age: u8) -> String {
    format!("Hello, {} year old named {}!", age, name)
}

#[launch]
fn rocket() -> _ {
    rocket::build().mount("/hello", routes![hello]).mount("/", routes![index])
}
