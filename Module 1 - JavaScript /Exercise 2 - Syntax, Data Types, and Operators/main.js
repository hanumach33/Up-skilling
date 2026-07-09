const eventName = "Community Music Festival";
const eventDate = "20 July 2026";
let availableSeats = 100;

console.log(`Event: ${eventName}`);
console.log(`Date: ${eventDate}`);
console.log(`Available Seats: ${availableSeats}`);

availableSeats--;

console.log(`Seats After Registration: ${availableSeats}`);

availableSeats++;

console.log(`Seats After Cancellation: ${availableSeats}`);
