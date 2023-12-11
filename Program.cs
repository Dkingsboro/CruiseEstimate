using static System.Console;
namespace CruiseEstimate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String variable for the assignment of user input string roomType;
            string roomType;
            string drinkChoice;
            string tripChoice;
            string transferChoice;

            // Double vairables for the price of each selection
            double roomPrice;
            double drinkPrice;
            double tripPrice;
            double transferPrice;
            double totalPrice;

            // Gathering user input for their choices
            WriteLine("Enter state room type. Choices are INSIDE, OUTSIDE, BALCONY,DELUXE BALCONY");
            roomType = ReadLine();

            WriteLine("Enter drinks choice. Choices are ALCOHOL, NON-ALCOHOL, NONE ALCOHOL");
            drinkChoice = ReadLine();

            WriteLine("Interested in optional shore trip? Choices are YES or NO");
            tripChoice = ReadLine();

            WriteLine("Interested in airport transfer? Options are RETURN, ONEWAY, NONE RETURN");
            transferChoice = ReadLine();

            // Calling and running methods in order to assign prices based off of user choices
            roomPrice = RoomSelection(roomType);
            drinkPrice = DrinkSelection(drinkChoice);
            tripPrice = TripSelection(tripChoice);
            transferPrice = TransferSelection(transferChoice);

            // Calculating total price for the vacation
            totalPrice = (roomPrice + drinkPrice + tripPrice + transferPrice);

            // Displaying itemized list of all selections by user
            WriteLine("Cruise Vacation Package Selection");
            WriteLine("------------------------------------------");
            WriteLine("State Room type chosen is " + roomType + " at a price : {0:C}", roomPrice);
            WriteLine("Drink package chosen is " + drinkChoice + " at a price : {0:C}",
            drinkPrice);
            WriteLine("Optional Shore trip chosen is " + tripChoice + " at a price : {0:C}",
            tripPrice);
            WriteLine("Airport Tranafer chosen is " + transferChoice + " at a price : {0:C}",
            transferPrice);
            WriteLine("Estimated cost for two adults: {0:C}", totalPrice);
            WriteLine("------------------------------------------");
        }
            // Method for assigning prices to room type that user selected
             static double RoomSelection(string roomType)
             {
                // Assigning prices to different rooms.
                double insideRoom = 3500;
                double outsideRoom = 4000;
                double balconyRoom = 5500;
                double deluxeRoom = 7000;

                double roomPrice = 0; // Declaring the selected room price to return through the main

                // If else statement to decide exactly what room the user selected and what price to assign it
                if (roomType == "INSIDE")
                {
                    roomPrice = insideRoom;
                }
                else if (roomType == "OUTSIDE")
                {
                    roomPrice = outsideRoom;
                }
                else if (roomType == "BALCONY")
                {
                    roomPrice = balconyRoom;
                }
                else if (roomType == "DELUXE BALCONY")
                {
                    roomPrice = deluxeRoom;
                }
                return roomPrice; // returns correct selected room price
             }

            // Method for assigning prices to drink choice that user selected
        static double DrinkSelection(string drinkChoice)
        {
            // Assigning prices to different choices
            double alcohol = 350;
            double nonAlcohol = 150;
            double drinkPrice = 0; // Total price of selected package to return later
                                   // If else statement to decide what price to assign which selection
            if (drinkChoice == "ALCOHOL")
            {
                drinkPrice = alcohol;
            }
            else if (drinkChoice == "NON-ALCOHOL")
            {
                drinkPrice = nonAlcohol;
            }
            else if (drinkChoice == "NON-ACOHOL")
            {
                drinkPrice = 0;
            }
            return drinkPrice; // Returns correct drink price for selected package
        }
        // Method for assigning prices to correct Shore Trip choice that the user selected
        static double TripSelection(string tripChoice)
        {
            // Sets value for the trip price if YES, and declares total to be returned later
            double tripYES = 650;
            double tripPrice = 0;
            // If else statement to decide what selection user made
            if (tripChoice == "YES")
            {
                tripPrice = tripYES;
            }
            else if (tripChoice == "NO")
            {
                tripPrice = 0;
            }
            return tripPrice; // Returns trip price to Main
        }
        // Method for assigning price to Transfer selection that user chose
        static double TransferSelection(string transferChoice)
        {
            // prices for return and one way fare
            double returnFare = 80;
            double oneWayFare = 45;
            double transferPrice = 0; // tranfer price to be returned later

            // If else statement do decide what user selected and what price to assign
            if (transferChoice == "RETURN")
            {
                transferPrice = returnFare;
            }
            else if (transferChoice == "ONEWAY")
            {
                transferPrice = oneWayFare;
            }
            else if (transferChoice == "NONE RETURN")
            {
                transferPrice = 0;
            }
            return transferPrice; // Returns price based off user selection
        }
    }
}
