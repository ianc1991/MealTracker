using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealLogger
{
    public interface IDataConnection
    {
        Dinner CreateDinner(Dinner model);
    }
}
