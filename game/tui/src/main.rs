use cursive::{views::Dialog, Cursive};

fn main() {
    let mut siv = cursive::default();

    siv.add_global_callback('q', |s| s.quit());

    siv.add_layer(Dialog::text("Hello").title("The title").button("arst", delete_layer));

    siv.run();
}

fn delete_layer(s: &mut Cursive)
{
    s.pop_layer();
}
