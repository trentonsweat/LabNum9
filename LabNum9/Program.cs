using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNum9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choice = true;     //boolean for program while loop to allow it to keep running until user quits

            string yesOrNo = "";     //user input of Y or N to execute the while loop

            int count = 0;          //count of the objects made



            while (choice)

            {

                Circle circleApp = new Circle();                    //Creates a circle object

                count++;                                            //keeps count of all objects created

                Console.WriteLine("Welcome!\n");

               



                Console.WriteLine("Enter in radius");

                circleApp.Radius = double.Parse(Console.ReadLine());        //Set user radius through Radius property

                if (circleApp.Radius < 0)                        //Validates user radius to make sure it is positive

                {

                    bool boo_lean = true;

                    while (circleApp.Radius < 0)

                    {

                        Console.WriteLine("Enter in a right value for radius");

                        circleApp.Radius = double.Parse(Console.ReadLine());

                    }



                }



                Console.WriteLine("This is the circumference: " + circleApp.GetCircumference());    //Display Circumference of circle

                Console.WriteLine("This is the area: " + circleApp.GetArea());                      //Display Area of circle 



                Console.WriteLine("Do you want to continue Y or N???");

                yesOrNo = Console.ReadLine().ToUpper();



                if (yesOrNo == "Y")

                {

                    choice = true;



                }

                else if (yesOrNo == "N")

                {

                    choice = false;

                    Console.WriteLine("Goodbye, You created" + " " + count + " " + "object(s)");

                }


            }
        }
    }
}
