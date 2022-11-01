using System.ComponentModel.DataAnnotations;
// Ryan Dunphy Lab 7
namespace TipCalculatorWk7.Models
{
   public class TipCalculator
   {
      [Required(ErrorMessage = "Please enter a value for cost of meal.")]
      [Range(0.0, 10000000.0, ErrorMessage = "Cost of meal must be greater than zero.")]
      public double? MealCost { get; set; }

      public double CalculateTip(double percent)
      {
         if (MealCost.HasValue)
         {
            // Program was using division instead of multiplication. Since this is a percent, it needs to be multiplied. 
            var tip = (MealCost.Value * percent);
                return tip;                          
         }
         else
         {
            return 0;
         }

      }
   }
}
