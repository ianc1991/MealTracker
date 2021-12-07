using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealLogger
{    
    public static class TextConnectorProcessor
    {
        // Returns files path name as string        
        public static string FullFilePath(this string fileName)
        {
            string val = ConfigurationManager.AppSettings["filePath"]; // Grabs key filePath from App.config
            string path = System.Environment.ExpandEnvironmentVariables(val); // Used to convert %appdata% to explorer path.

            return $"{ path }\\{ fileName }";
        }

        // Returns directory path
        public static string DirectoryLocation()
        {
            string val = ConfigurationManager.AppSettings["filePath"]; // Grabs key filePath from App.config
            string path = System.Environment.ExpandEnvironmentVariables(val); // Used to convert %appdata% to explorer path.

            return path;
        }

        // Loads text file, or creates a new one if it doesn't exist
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        // DINNER PROCESSING

        // Saves the Dinner model to text
        public static void SaveToDinnerFile(this List<Dinner> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Dinner p in models)
            {
                lines.Add($"{ p.Id },{ p.DinnerName }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        // Takes the text file and converts it back to a model
        public static List<Dinner> ConvertToDinner(this List<string> lines)
        {
            List<Dinner> output = new List<Dinner>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Dinner p = new Dinner();
                p.Id = int.Parse(cols[0]);
                p.DinnerName = cols[1];
                output.Add(p);
            }

            return output;
        }

        // LUNCH PROCESSING

        // Saves the Lunch model to text
        public static void SaveToLunchFile(this List<Lunch> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Lunch p in models)
            {
                lines.Add($"{ p.Id },{ p.LunchName },{p.IsLeftover}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        // Takes the text file and converts it back to a model
        public static List<Lunch> ConvertToLunch(this List<string> lines)
        {
            List<Lunch> output = new List<Lunch>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Lunch p = new Lunch();
                p.Id = int.Parse(cols[0]);
                p.LunchName = cols[1];
                p.IsLeftover = bool.Parse(cols[2]);
                output.Add(p);
            }

            return output;
        }

        // Takes the text file and converts it back to a model
        public static List<LoFood> ConvertToLoFood(this List<string> lines)
        {
            List<LoFood> output = new List<LoFood>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                LoFood p = new LoFood();
                p.Id = int.Parse(cols[0]);
                p.LoFoodName = cols[1];
                output.Add(p);
            }

            return output;
        }

        // Saves the Lunch model to text
        public static void SaveToLoFoodFile(this List<LoFood> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (LoFood p in models)
            {
                lines.Add($"{ p.Id },{ p.LoFoodName }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }

}
