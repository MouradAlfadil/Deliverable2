// See https://aka.ms/new-console-template for more information
//beginning with a introduction statement to the customers
Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
//creating variables for customer count and taking the user input and assigning it to that variable 
int customercount=Int32.Parse(Console.ReadLine());
// the bill total will be a double value because money
double bill;
//this will count that amount of coffees ordered to be charged later on
int coffeecount = 0;
int watercount = 0;
//creating a condition that will reject parties greater than 6 and take orders of parties of 6 and smaller
if (customercount > 6)
{
    Console.WriteLine("Sorry we cannot take in a group that large please leave the establishment.");
}
else if (customercount <= 6)
{
    //taking customer order 1:customercount
    Console.WriteLine("So will we be having drinks today?");
    for (int i = 1; i <= customercount; i++)
    {
        Console.WriteLine("So customer " + i + " what will it be? coffee or water?");
        string drinkchoice = Console.ReadLine();
        if (drinkchoice == "coffee")
        {
            coffeecount++;
            Console.WriteLine("Okay coffee it is!");
        }
        else if (drinkchoice == "water")
        {
            Console.WriteLine("Okay water it is!");
            watercount++;
        }
        else
        {
            Console.WriteLine("Sorry we dont have that.");
        }
    }
    //adding up total for bill
    double total = ((customercount * 9.99) + (coffeecount * 2));
    Console.WriteLine("Okay that will be " + watercount + " orders of water and " + coffeecount + " orders of coffee");
    Console.WriteLine("Your total today is " + total + ". Have a nice day!");
}

