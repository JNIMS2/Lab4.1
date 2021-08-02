using System;

namespace Lab4_1
{//create parallellogram class, give it double L and W
    class Parallelogram
    {
        public double L;
        public double W;

        //create all my methods:
        public double GetArea()
        {
            return L * W;
        }
        public double GetPerimiter()
        { 
            return (2*L) + (2 *W);
        }
        public void PrintPara()
        {
            Console.WriteLine($"Width: {W}");
            Console.WriteLine($"Length: {L}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {GetPerimiter()}");
        }
        public void Resize(double newL, double newW)//idk what exactly resize does...i figured it out...i had to reprint to see the change... :)
        {//not sure if i should keep the if's separate or put it together...
            if (newL < 0)
            {
                return;
            }
            L = newL;

            if (newW < 0)
            {
                return;
            }
            W = newW;
        }
    
    }
    //make my book class
    class Book
    {
        public string Title;//it was driving me crazy that it wasn't printing a title...IS there an easier way to get it to print the name, like when we create the books below??
        public string ALAstName;
        public string AFirstName;
        public string ID;
        public string PubName;
        public int CopSold;
     

        //create the methods
        public void PrintBk()
        {//making it readable to users:
            Console.WriteLine($"Book: {Title}");
            Console.WriteLine($"Author name: {AFirstName} {ALAstName}.");
            Console.WriteLine($"ISBN: {ID}");
            Console.WriteLine($"Published by: {PubName}");
            Console.WriteLine($"Number of Copies sold: {CopSold}");
        
        }

        public void Sell(int newSale)
        { //trying out this += thing

            CopSold += newSale;//is the same as CopSold = CopSold + newSale;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle jazz: ");
            //makin' some Parallelograms

            Parallelogram Blue = new Parallelogram() { L = 20, W = 30 };
            //call it's methods...); trying to make it look nicer....
            Console.WriteLine($"Length: {Blue.L}");
            Console.WriteLine($"Width: {Blue.W}");
            Console.WriteLine($"Area: {Blue.GetArea()}");
            Console.WriteLine($"Perimeter {Blue.GetPerimiter()}");
            Console.WriteLine("\nAll of it: ");
            Blue.PrintPara();
            Blue.Resize(15, 20);
            Console.WriteLine("\nLet's change it up");
            Blue.PrintPara();
            Console.WriteLine();

            Parallelogram Red = new Parallelogram() { L = 45, W = 35 };
            Console.WriteLine($"Length: {Red.L}");
            Console.WriteLine($"Width: {Red.W}");
            Console.WriteLine($"Area: {Red.GetArea()}");
            Console.WriteLine($"Perimeter {Red.GetPerimiter()}");
            Console.WriteLine("\nAll of it: ");
            Red.PrintPara();
            Red.Resize(10, 20);
            Console.WriteLine("\nChanging this one: ");
            Red.PrintPara();


            Console.WriteLine("\nBook Stuff: ");

            //inside main make a book.
            //making the titles that i'm working on....

            Book TheInvisibleThings = new Book() {Title = "The Invisible Things", AFirstName = "Mary J.", ALAstName = "Wright", ID = "2389dshks", PubName = "IDK yet", CopSold = 300 };
            //call it's functions
            TheInvisibleThings.PrintBk();
            Console.WriteLine();
            TheInvisibleThings.Sell(1000);
            Console.WriteLine("Hey, we sold some more books!");
            TheInvisibleThings.PrintBk();
            Console.WriteLine();

            //make a couple more books

            Book Mrs_Mucklebees_Secret_Hamster_Village = new Book() {Title = "Mrs. Mucklebee's Secret Hamster Adventure",AFirstName = "Mary J.", ALAstName = "Wright", ID = "283djsd", PubName = "Still_dont_know", CopSold = 500 };
            Mrs_Mucklebees_Secret_Hamster_Village.PrintBk();
            Console.WriteLine();
            Console.WriteLine("Let's sell some more books!");
            TheInvisibleThings.Sell(200000);
            Mrs_Mucklebees_Secret_Hamster_Village.PrintBk();
            Console.WriteLine();

            Book Be_Careful_What_you_wish_for = new Book() {Title = "Be Careful What You Wish For...", AFirstName = "Janet Lee", ALAstName = "Caldwell", ID = "3948WEJwe", PubName = "Someone Good Hopefully", CopSold = 300 };
            Be_Careful_What_you_wish_for.PrintBk();
            Console.WriteLine();
            Console.WriteLine("Boom, we sold a ton more!!");
            Be_Careful_What_you_wish_for.Sell(200000);
            Be_Careful_What_you_wish_for.PrintBk();
            Console.WriteLine();




        }
    }
}
