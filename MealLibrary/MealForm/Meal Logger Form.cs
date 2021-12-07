using MealLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealForm
{
    public partial class MealLoggerForm : Form
    {
        // TODO - Add a settings menu.
        // TODO - Add button to add a leftover ingredient. 

        public MealLoggerForm()
        {
            InitializeComponent();

            // Checks if directory exists
            if (!Directory.Exists(TextConnectorProcessor.DirectoryLocation()))
            {
                MessageBox.Show("The application data folder does not exist and no data can be saved. Please rerun the installer. If that does not work, manually create the folder at %appdata%\\MealLogger. The program will now close.");
                
            }
        }


        // TODO - Fix memory leak with opening/closing forms. Memory leaking when pressing all buttons, even empty? This might just be normal WinForms behaviour.
        private void addMealButton_Click(object sender, EventArgs e)
        {
            Add_Meal_Form form2 = new Add_Meal_Form();
            form2.FormClosing += new FormClosingEventHandler(this.Add_Meal_Form_FormClosing);
            form2.ShowDialog();
        }

        private void Add_Meal_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            WireUpLists();
        }

        private void AddLeftOver_FormClosing(object sender, FormClosingEventArgs e)
        {
            WireUpLists();
        }

        private void MealLoggerForm_Load(object sender, EventArgs e)
        {
            WireUpLists();
        }

        private void lunchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void deleteDinnerButton_Click(object sender, EventArgs e)
        {
            String d = (String)dinnerListBox.SelectedItem;
            List<Dinner> dinners = DataControl.DinnersFromText();

            if (d != null)
            {
                foreach (Dinner item in dinners) // TODO - Handle if two dinner names have the same name. Currently, it will remove the first one in the list.
                                                 // Without the break, the foreach loop will crash after data is removed
                {
                    if (item.DinnerName == d)
                    {
                        dinners.Remove(item);
                        dinners.SaveToDinnerFile(DataControl.DinnerFile);
                        AddToLoList();
                        break;
                    }
                }

                var result = MessageBox.Show("Leftovers for lunch?", "Meal Logger", MessageBoxButtons.YesNo); // TODO - Make the messagebox a form to enable centering to parent
                if (result == DialogResult.Yes)
                {
                    List<Lunch> y = DataControl.LunchesFromText();
                    Lunch x = new Lunch();
                    x.LunchName = $"Leftover { d }";
                    x.IsLeftover = true;
                    y.Add(x);
                    y.SaveToLunchFile(DataControl.LunchFile);
                }
            }

            WireUpLists();
        }

        private void removeLunchButton_Click(object sender, EventArgs e)
        {
            String d = (String)lunchListBox.SelectedItem;
            List<Lunch> lunches = DataControl.LunchesFromText();

            if (d != null)
            {
                foreach (Lunch item in lunches) // TODO - Handle if two names have the same name
                                                // Without the break, the foreach loop will crash after data is removed
                {
                    if (item.LunchName == d)
                    {
                        lunches.Remove(item);
                        lunches.SaveToLunchFile(DataControl.LunchFile);

                        if(item.IsLeftover == false)
                        {
                            AddToLoList();
                        }
                        break;
                    }
                }
            }

            WireUpLists();
        }

        private void removeIngredientButton_Click(object sender, EventArgs e)
        {
            String d = (String)loListBox.SelectedItem;
            List<LoFood> lo = DataControl.LoFoodFromText();

            if (d != null)
            {
                foreach (LoFood item in lo) // TODO - Handle if two names have the same name / have multiple ingredients.
                {
                    if (item.LoFoodName == d)
                    {
                        lo.Remove(item);
                        lo.SaveToLoFoodFile(DataControl.LoFoodFile);
                        break;
                    }
                }
            }
            WireUpLists();
        }

        // Non form event Methods

        // Refreshes List boxes by removing all data from the box and reloading data
        private void WireUpLists()
        {
            lunchListBox.Items.Clear();
            dinnerListBox.Items.Clear();
            loListBox.Items.Clear();

            List<Lunch> y = DataControl.LunchesFromText();
            List<Dinner> d = DataControl.DinnersFromText();
            List<LoFood> l = DataControl.LoFoodFromText();

            foreach (Lunch x in y)
            {
                lunchListBox.Items.Add(x.LunchName);
            }

            foreach (Dinner x in d)
            {
                dinnerListBox.Items.Add(x.DinnerName);
            }

            foreach (LoFood x in l)
            {
                loListBox.Items.Add(x.LoFoodName);
            }
        }

        private void AddToLoList()
        {
            var result = MessageBox.Show("Any perishable leftover ingredients?", "Meal Logger", MessageBoxButtons.YesNo); // TODO - Make the messagebox a form to enable centering to parent
            if (result == DialogResult.Yes)
            {
                AddLeftOver form2 = new AddLeftOver();
                form2.FormClosing += new FormClosingEventHandler(this.Add_Meal_Form_FormClosing);
                form2.ShowDialog();
            }
        }
    }
}
