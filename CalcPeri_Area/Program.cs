using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPeri_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                
                ////////////////////////////////// input
                Console.WriteLine("Please Enter the any lenght value ");
                string lenght = Console.ReadLine();

                Console.WriteLine("Please Enter the any width value ");
                string width = Console.ReadLine();

                Console.WriteLine("Please Enter the any height value ");
                string height = Console.ReadLine();

                //Console.WriteLine("Please Enter the any vol value ");
                // string width = Console.ReadLine();

                ////////////////////////////////////////////////////////

                //calculate Area and Perimeter
                double len = double.Parse(lenght);
                double widt = double.Parse(width);
                double heig = double.Parse(height);

                double area = len * widt;

                double perimeter = 2 * len + 2 * widt;

                double volume = area * heig;
                ///////////////////////////////////////////////////////
                //Prints out the Area, Perimenter and Volume
                Console.WriteLine("The Area of classroom = {0} ", area);
                Console.WriteLine("The Peri of the classroom = {0} ", perimeter);
                Console.WriteLine("The Volume of the classroom = {0} ", volume);

                Console.WriteLine("Do you want to continue ");
                string userInput = Console.ReadLine();
                if (userInput == "No" )
                {
                    break;

                }

            }



        }
        
    }
}
