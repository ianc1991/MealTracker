using MealLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealForm
{
    public partial class AddLeftOver : Form
    {
        public AddLeftOver()
        {
            InitializeComponent();
        }

        private void AddLeftOver_Load(object sender, EventArgs e)
        {

        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            LoFood l = new LoFood();

            if (loNameText.Text != "")
            {
                l.LoFoodName = loNameText.Text;
                TextConnector.CreateLeftOver(l);
                MessageBox.Show("Leftover ingredient added!"); // TODO - Make the messagebox a form to enable centering to parent
            }

            else
            {
                MessageBox.Show("Enter an ingredient.");
            }

            loNameText.Text = "";
        }
    }
}
