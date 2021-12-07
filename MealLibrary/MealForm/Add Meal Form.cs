using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MealLogger;

namespace MealForm
{
    public partial class Add_Meal_Form : Form
    {
        public Add_Meal_Form()
        {
            InitializeComponent();
        }

        private void addMealButton_Click(object sender, EventArgs e)
        {
            
            if (ValidateForm())
            {
                if (dinnerRadioButton.Checked == true)
                {
                    Dinner d = new Dinner
                    {
                        DinnerName = mealNameText.Text
                    };

                    TextConnector.CreateDinner(d);

                    MessageBox.Show("Meal has been created!");  // TODO - Make the messagebox a form to enable centering to parent
                    mealNameText.Text = "";
                    dinnerRadioButton.Checked = false;
                }

                else if (lunchRadioButton.Checked == true)
                {
                    Lunch d = new Lunch
                    {
                        LunchName = mealNameText.Text
                    };

                    TextConnector.CreateLunch(d);

                    MessageBox.Show("Meal has been created!");
                    mealNameText.Text = "";
                    lunchRadioButton.Checked = false;
                }
                
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        // VALIDATE FORM
        private bool ValidateForm()
        {
            if (mealNameText.Text.Length == 0)
            {
                return false;
            }

            if (lunchRadioButton.Checked == false && dinnerRadioButton.Checked == false)
            {
                return false;
            }

            return true;
        }

        // FORM MANIPULATION (opening/ closing)

        // BACK BUTTON
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Meal_Form_Load(object sender, EventArgs e)
        {

        }

        private void mealNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void mealName_Click(object sender, EventArgs e)
        {

        }
    }
}
