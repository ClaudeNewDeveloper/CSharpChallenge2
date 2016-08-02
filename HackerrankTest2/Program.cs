/*Author: Claude Boulingui
 * Compute total cost of meal.
 * This application is for Console
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerrankTest2
{
    class Meal
    {
      
        double totalCost = 0.0;

        Meal(double MealCost, int tipPercent, int taxPercent) 
        {
          double  mealPrice = MealCost;
          double tip = mealPrice * (tipPercent / 100.0);
          double tax = mealPrice * (taxPercent / 100.0);

          totalCost = mealPrice + tip + tax;
        
       
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the cost of meal, tip and tax");
            double  MealCost = Convert.ToDouble (Console.ReadLine());

            int tipPercent = Convert.ToInt32 (Console.ReadLine());
            int taxPercent = Convert.ToInt32 (Console.ReadLine());

            Meal customerMeal = new Meal(MealCost, tipPercent, taxPercent);


           Console.WriteLine(" The total meal cost is " + Convert.ToInt32 (customerMeal.totalCost) + " dollars ");

           Console.ReadKey(); // Just to force the console window to stay on the screen without disapearing
        }
    }
}
