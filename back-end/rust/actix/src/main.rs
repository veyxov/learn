use rocket::tokio::time::{sleep, Duration};

#[macro_use] extern crate rocket;

#[get("/")]
fn index() -> &'static str {
    "Hello world"
}

#[get("/<name>/<age>")]
fn hello(name: &str, age: u8) -> String {
    format!("Hello, {} year old named {}!", age, name)
}

#[get("/<seconds>")]
async fn delay(seconds: u64) -> String {
    sleep(Duration::from_secs(seconds)).await;
    format!("Waited for {}", seconds)
}

#[launch]
fn rocket() -> _ {
    rocket::build()
        .mount("/hello", routes![hello])
        .mount("/", routes![index])
        .mount("/delay", routes![delay])
}
