using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealLogger
{
    public class TextConnector
    {
        public static Dinner CreateDinner(Dinner model)
        {
            List<Dinner> dinnerList = DataControl.DinnersFromText();

            int currentId = 1;

            if (dinnerList.Count > 0)
            {
                currentId = dinnerList.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            dinnerList.Add(model);

            dinnerList.SaveToDinnerFile(DataControl.DinnerFile);

            return model;
        }

        public static Lunch CreateLunch(Lunch model)
        {
            List<Lunch> lunchList = DataControl.LunchesFromText();

            int currentId = 1;

            if (lunchList.Count > 0)
            {
                currentId = lunchList.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            lunchList.Add(model);

            lunchList.SaveToLunchFile(DataControl.LunchFile);

            return model;
        }

        public static LoFood CreateLeftOver(LoFood model)
        {
            List<LoFood> loList = DataControl.LoFoodFromText();

            int currentId = 1;

            if (loList.Count > 0)
            {
                currentId = loList.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            loList.Add(model);

            loList.SaveToLoFoodFile(DataControl.LoFoodFile);

            return model;
        }
    }
}
