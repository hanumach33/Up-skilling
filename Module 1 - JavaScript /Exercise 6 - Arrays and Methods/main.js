const events = [
    {
        name: "Music Festival",
        category: "Music"
    },
    {
        name: "Food Carnival",
        category: "Food"
    },
    {
        name: "Coding Workshop",
        category: "Education"
    }
];

events.push({
    name: "Live Concert",
    category: "Music"
});

console.log("All Events:");
console.log(events);

const musicEvents = events.filter(event => event.category === "Music");

console.log("Music Events:");
console.log(musicEvents);

const formattedEvents = events.map(event => `Workshop on ${event.name}`);

console.log("Formatted Event Names:");
formattedEvents.forEach(event => {
    console.log(event);
});
