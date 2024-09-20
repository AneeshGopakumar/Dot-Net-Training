using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace Milestone_3 
{ 
    // Abstract Class for Flights
    abstract class Flight
    {
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public double BaseFare { get; set; }

        public Flight(string flightNumber, string destination, double baseFare)
        {
            FlightNumber = flightNumber;
            Destination = destination;
            BaseFare = baseFare;
        }

        public abstract double CalculateFare();
        public abstract void DisplayDetails();
    }

    // Domestic Flight
    class DomesticFlight : Flight
    {
        public DomesticFlight(string flightNumber, string destination, double baseFare)
            : base(flightNumber, destination, baseFare) { }

        public override double CalculateFare()
        {
            return BaseFare + 50; // Fee for domestic flights
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Domestic Flight: {FlightNumber}, Destination: {Destination}, Fare: {CalculateFare()}");
        }
    }

    // International Flight
    class InternationalFlight : Flight
    {
        public InternationalFlight(string flightNumber, string destination, double baseFare)
            : base(flightNumber, destination, baseFare) { }

        public override double CalculateFare()
        {
            return BaseFare + 200; // Fee for international flights
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"International Flight: {FlightNumber}, Destination: {Destination}, Fare: {CalculateFare()}");
        }
    }

    // Passenger Class
    class Passenger
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Passenger(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }

    // IBooking Interface
    interface IBooking
    {
        void BookTicket(Flight flight, Passenger passenger);
        void CancelBooking(int bookingId);
        void GetBookingDetails(int bookingId);
    }

    // Online Booking
    class OnlineBooking : IBooking
    {
        private Dictionary<int, (Flight, Passenger)> bookings = new Dictionary<int, (Flight, Passenger)>();
        private int nextBookingId = 1;

        public void BookTicket(Flight flight, Passenger passenger)
        {
            bookings[nextBookingId] = (flight, passenger);
            Console.WriteLine($"Online booking confirmed. Booking ID: {nextBookingId}, Passenger: {passenger.Name}");
            nextBookingId++;
        }

        public void CancelBooking(int bookingId)
        {
            if (bookings.ContainsKey(bookingId))
            {
                bookings.Remove(bookingId);
                Console.WriteLine($"Booking ID {bookingId} canceled.");
            }
            else
            {
                Console.WriteLine($"Booking ID {bookingId} not found.");
            }
        }

        public void GetBookingDetails(int bookingId)
        {
            if (bookings.ContainsKey(bookingId))
            {
                var booking = bookings[bookingId];
                Console.WriteLine($"Booking ID: {bookingId}, Flight: {booking.Item1.FlightNumber}, Passenger: {booking.Item2.Name}");
            }
            else
            {
                Console.WriteLine($"Booking ID {bookingId} not found.");
            }
        }
    }

    // Agency Booking
    class AgencyBooking : IBooking
    {
        private List<(int, Flight, Passenger)> bookings = new List<(int, Flight, Passenger)>();
        private int nextBookingId = 1;

        public void BookTicket(Flight flight, Passenger passenger)
        {
            bookings.Add((nextBookingId, flight, passenger));
            Console.WriteLine($"Agency booking confirmed. Booking ID: {nextBookingId}, Passenger: {passenger.Name}");
            nextBookingId++;
        }

        public void CancelBooking(int bookingId)
        {
            var booking = bookings.FirstOrDefault(b => b.Item1 == bookingId);
            if (booking != default)
            {
                bookings.Remove(booking);
                Console.WriteLine($"Booking ID {bookingId} canceled.");
            }
            else
            {
                Console.WriteLine($"Booking ID {bookingId} not found.");
            }
        }

        public void GetBookingDetails(int bookingId)
        {
            var booking = bookings.FirstOrDefault(b => b.Item1 == bookingId);
            if (booking != default)
            {
                Console.WriteLine($"Booking ID: {bookingId}, Flight: {booking.Item2.FlightNumber}, Passenger: {booking.Item3.Name}");
            }
            else
            {
                Console.WriteLine($"Booking ID {bookingId} not found.");
            }
        }
    }

    // Main Class
    class FlightBookingSystem
    {
        private Flight[] flightArray = new Flight[5];
        private List<Flight> flightList = new List<Flight>();

        public void AddFlight(Flight flight)
        {
            if (flightList.Count < 5)
            {
                flightArray[flightList.Count] = flight;
            }
            flightList.Add(flight);
        }

        public void RemoveFlight(string flightNumber)
        {
            flightList.RemoveAll(f => f.FlightNumber == flightNumber);
        }

        public Flight SearchFlight(string flightNumber)
        {
            return flightList.FirstOrDefault(f => f.FlightNumber == flightNumber);
        }

        public void DisplayFlights()
        {
            foreach (var flight in flightList)
            {
                flight.DisplayDetails();
            }
        }

        public void FilterFlightsByDestination(string destination)
        {
            var result = flightList.Where(f => f.Destination == destination);
            Console.WriteLine("Filtered Flights:");
            foreach (var flight in result)
            {
                flight.DisplayDetails();
            }
        }

        public void SortFlightsByFare()
        {
            var result = flightList.OrderBy(f => f.CalculateFare());
            Console.WriteLine("Sorted Flights by Fare:");
            foreach (var flight in result)
            {
                flight.DisplayDetails();
            }
        }

        public void LoadFlightsFromFile(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts[0] == "Domestic")
                    {
                        AddFlight(new DomesticFlight(parts[1], parts[2], double.Parse(parts[3])));
                    }
                    else if (parts[0] == "International")
                    {
                        AddFlight(new InternationalFlight(parts[1], parts[2], double.Parse(parts[3])));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }

        public void SaveFlightsToFile(string filePath)
        {
            try
            {
                var lines = flightList.Select(f =>
                    $"{(f is DomesticFlight ? "Domestic" : "International")},{f.FlightNumber},{f.Destination},{f.BaseFare}");
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing file: {ex.Message}");
            }
        }

        // Regular Expressions for Validation
        public bool ValidateFlightNumber(string flightNumber)
        {
            return Regex.IsMatch(flightNumber, @"^FL\d{4}$");
        }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }
    }

    class Program
    {
        // Main Method
        static void Main(string[] args)
        {
            FlightBookingSystem fbSystem = new FlightBookingSystem();

            // Add Flights
            fbSystem.AddFlight(new DomesticFlight("IA819", "New Delhi", 7500));
            fbSystem.AddFlight(new InternationalFlight("EM573", "Dubai", 16000));

            // Display Flights
            fbSystem.DisplayFlights();

            // Filter by Destination
            fbSystem.FilterFlightsByDestination("New Delhi");

            // Sort by Fare
            fbSystem.SortFlightsByFare();

            // Booking Example
            IBooking onlineBooking = new OnlineBooking();
            Passenger passenger = new Passenger("David Warner", "Dw@abc.com", "1234567890");
            onlineBooking.BookTicket(fbSystem.SearchFlight("EM573"), passenger);
            Passenger passenger2 = new Passenger("Ricky Ponting", "Rp@abc.com", "1234567890");
            onlineBooking.BookTicket(fbSystem.SearchFlight("IA819"), passenger2);

            // File Handling
            fbSystem.SaveFlightsToFile("flights.csv");
            fbSystem.LoadFlightsFromFile("flights.csv");
        }
    }
}