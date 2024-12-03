using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class 
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */



            var birdOne = new bird();
            birdOne.Name = "Eagle";
            birdOne.Age = 2;
            birdOne.Diet = "Insects and small rodents";
            birdOne.IsNocturnal = false;
            birdOne.BeakType = "hooked";
            birdOne.CanFly = true;
            birdOne.FeatherColor = "Golden brown and white";
            birdOne.WingSpan = 12;

            Console.WriteLine($"Name: {birdOne.Name}\nAge: {birdOne.Age}\nDiet {birdOne.Diet}\nNocturnal: {birdOne.IsNocturnal}\nBeak: {birdOne.BeakType}\nFlight: {birdOne.CanFly}\nFeather: {birdOne.FeatherColor}\nWing Span: {birdOne.WingSpan} inches");
            Console.WriteLine("");

            var reptileOne = new Reptile()
            {
                Name = "Python",
                Age = 1,
                Diet = "Small rodents",
                IsNocturnal = true,
                ForkTounge = true,
                HasShell = false,
                IsVenomous = true,
                ScaleColor = "yellow"
            };

            Console.WriteLine($"Name: {reptileOne.Name}\nAge: {reptileOne.Age}\nDiet: {reptileOne.Diet}\nNocturnal: {reptileOne.IsNocturnal}\nForked Tounge: {reptileOne.ForkTounge}\nShell: {reptileOne.HasShell}\nVenomous: {reptileOne.IsVenomous}\nScale Color: {reptileOne.ScaleColor}");
        }
    }
}
