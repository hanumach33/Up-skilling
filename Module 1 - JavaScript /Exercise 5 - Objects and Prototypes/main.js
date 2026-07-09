function Event(name, category, date, seats) {
    this.name = name;
    this.category = category;
    this.date = date;
    this.seats = seats;
}

Event.prototype.checkAvailability = function () {
    if (this.seats > 0) {
        return "Seats Available";
    }

    return "House Full";
};

const event1 = new Event(
    "Music Festival",
    "Music",
    "20-Jul-2026",
    50
);

console.log(event1.checkAvailability());

console.log("Event Details:");

Object.entries(event1).forEach(function ([key, value]) {
    console.log(`${key}: ${value}`);
});
