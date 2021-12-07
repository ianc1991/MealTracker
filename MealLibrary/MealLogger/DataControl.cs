using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealLogger
{

    
    public static class DataControl
    {
        public const string LunchFile = "Lunches.csv";
        public const string DinnerFile = "Dinners.csv";
        public const string LoFoodFile = "Leftovers.csv";

        public static List<Lunch> LunchesFromText()
        {            
            List<Lunch> x = LunchFile.FullFilePath().LoadFile().ConvertToLunch();
            return x;
        }

        public static List<Dinner> DinnersFromText()
        {
            List<Dinner> x = DinnerFile.FullFilePath().LoadFile().ConvertToDinner();
            return x;
        }

        public static List<LoFood> LoFoodFromText()
        {
            List<LoFood> x = LoFoodFile.FullFilePath().LoadFile().ConvertToLoFood();
            return x;
        }
    }
}