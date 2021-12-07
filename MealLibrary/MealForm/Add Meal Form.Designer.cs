
namespace MealForm
{
    partial class Add_Meal_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addMealHeader = new System.Windows.Forms.Label();
            this.mealName = new System.Windows.Forms.Label();
            this.mealNameText = new System.Windows.Forms.TextBox();
            this.lunchRadioButton = new System.Windows.Forms.RadioButton();
            this.dinnerRadioButton = new System.Windows.Forms.RadioButton();
            this.addMealButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMealHeader
            // 
            this.addMealHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.addMealHeader.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMealHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addMealHeader.Location = new System.Drawing.Point(0, 0);
            this.addMealHeader.Name = "addMealHeader";
            this.addMealHeader.Size = new System.Drawing.Size(375, 45);
            this.addMealHeader.TabIndex = 1;
            this.addMealHeader.Text = "Add Meal";
            this.addMealHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealName
            // 
            this.mealName.AutoSize = true;
            this.mealName.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mealName.Location = new System.Drawing.Point(12, 45);
            this.mealName.Name = "mealName";
            this.mealName.Size = new System.Drawing.Size(126, 30);
            this.mealName.TabIndex = 2;
            this.mealName.Text = "Meal Name:";
            this.mealName.Click += new System.EventHandler(this.mealName_Click);
            // 
            // mealNameText
            // 
            this.mealNameText.BackColor = System.Drawing.Color.White;
            this.mealNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mealNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealNameText.Location = new System.Drawing.Point(144, 47);
            this.mealNameText.Name = "mealNameText";
            this.mealNameText.Size = new System.Drawing.Size(212, 26);
            this.mealNameText.TabIndex = 3;
            this.mealNameText.TextChanged += new System.EventHandler(this.mealNameText_TextChanged);
            // 
            // lunchRadioButton
            // 
            this.lunchRadioButton.AutoSize = true;
            this.lunchRadioButton.Location = new System.Drawing.Point(144, 79);
            this.lunchRadioButton.Name = "lunchRadioButton";
            this.lunchRadioButton.Size = new System.Drawing.Size(55, 17);
            this.lunchRadioButton.TabIndex = 4;
            this.lunchRadioButton.TabStop = true;
            this.lunchRadioButton.Text = "Lunch";
            this.lunchRadioButton.UseVisualStyleBackColor = true;
            // 
            // dinnerRadioButton
            // 
            this.dinnerRadioButton.AutoSize = true;
            this.dinnerRadioButton.Location = new System.Drawing.Point(205, 79);
            this.dinnerRadioButton.Name = "dinnerRadioButton";
            this.dinnerRadioButton.Size = new System.Drawing.Size(56, 17);
            this.dinnerRadioButton.TabIndex = 5;
            this.dinnerRadioButton.TabStop = true;
            this.dinnerRadioButton.Text = "Dinner";
            this.dinnerRadioButton.UseVisualStyleBackColor = true;
            // 
            // addMealButton
            // 
            this.addMealButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMealButton.ForeColor = System.Drawing.Color.Red;
            this.addMealButton.Location = new System.Drawing.Point(144, 102);
            this.addMealButton.Name = "addMealButton";
            this.addMealButton.Size = new System.Drawing.Size(145, 38);
            this.addMealButton.TabIndex = 8;
            this.addMealButton.Text = "Add Meal";
            this.addMealButton.UseVisualStyleBackColor = true;
            this.addMealButton.Click += new System.EventHandler(this.addMealButton_Click);
            // 
            // Add_Meal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(375, 149);
            this.Controls.Add(this.addMealButton);
            this.Controls.Add(this.dinnerRadioButton);
            this.Controls.Add(this.lunchRadioButton);
            this.Controls.Add(this.mealNameText);
            this.Controls.Add(this.mealName);
            this.Controls.Add(this.addMealHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add_Meal_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Meal";
            this.Load += new System.EventHandler(this.Add_Meal_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addMealHeader;
        private System.Windows.Forms.Label mealName;
        private System.Windows.Forms.TextBox mealNameText;
        private System.Windows.Forms.RadioButton lunchRadioButton;
        private System.Windows.Forms.RadioButton dinnerRadioButton;
        private System.Windows.Forms.Button addMealButton;
    }
}