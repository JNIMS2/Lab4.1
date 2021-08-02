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
           
            Console.WriteLine(W);
            Console.WriteLine(L);
            Console.WriteLine(GetArea());
            Console.WriteLine(GetPerimiter());
        }
        public void Resize(double newL, double newW)//idk what exactly resize does...
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
    class Program
    {
        static void Main(string[] args)
        {
            //makin' some Parallelograms

            Parallelogram Blue = new Parallelogram() { L = 20, W = 30 };
            //call it's methods...
            Console.WriteLine(Blue.GetArea());
            Console.WriteLine(Blue.GetPerimiter());
            Blue.PrintPara();
            Blue.Resize(15, 20);//this printed 100. idk why. WHY?
            Console.WriteLine();

            Parallelogram Red = new Parallelogram() { L = 45, W = 35 };
            Console.WriteLine(Red.GetArea());
            Red.GetPerimiter();//should i just be writing stuff like this? and not include the writeline?
            Red.PrintPara();
            Red.Resize(10, 20);


        }
    }
}
