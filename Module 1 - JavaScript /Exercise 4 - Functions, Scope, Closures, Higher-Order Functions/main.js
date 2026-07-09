const events = [];

function addEvent(name, category, seats) {
    events.push({
        name,
        category,
        seats
    });
}

function registerUser(eventName) {
    const event = events.find(e => e.name === eventName);

    if (event && event.seats > 0) {
        event.seats--;
        console.log(`Successfully registered for ${event.name}`);
    } else {
        console.log("Registration failed.");
    }
}

function filterEventsByCategory(category, callback) {
    const filteredEvents = events.filter(event => event.category === category);
    callback(filteredEvents);
}

function registrationCounter() {
    let totalRegistrations = 0;

    return function () {
        totalRegistrations++;
        return totalRegistrations;
    };
}

const musicRegistration = registrationCounter();

addEvent("Music Festival", "Music", 50);
addEvent("Food Carnival", "Food", 30);
addEvent("Coding Workshop", "Education", 20);

registerUser("Music Festival");

console.log(`Music Registrations: ${musicRegistration()}`);
console.log(`Music Registrations: ${musicRegistration()}`);

filterEventsByCategory("Music", function (events) {
    console.log("Music Events:");
    events.forEach(event => {
        console.log(event.name);
    });
});
