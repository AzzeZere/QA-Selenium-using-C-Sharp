//Write a program and ask the user to enter the width and height of an image.
//Then tell if the image is landscape or portrait.





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapePortraitImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell if the image is Landscape or Portrait ?");
            Console.Write("Enter the Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = (width * height);
            Console.WriteLine("The area of the Image is: " + area);
            Console.Write("\n");

            if (width > height)
            {
                Console.WriteLine("It is a Landscape Image");
            }
            else
            {
                Console.WriteLine("It is a Portrait Image");
            }



        }
    }
}
