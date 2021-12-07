
namespace MealForm
{
    partial class MealLoggerForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.dinnerLabel = new System.Windows.Forms.Label();
            this.lunchLabel = new System.Windows.Forms.Label();
            this.LoLabel = new System.Windows.Forms.Label();
            this.dinnerListBox = new System.Windows.Forms.ListBox();
            this.lunchListBox = new System.Windows.Forms.ListBox();
            this.loListBox = new System.Windows.Forms.ListBox();
            this.addMealButton = new System.Windows.Forms.Button();
            this.deleteDinnerButton = new System.Windows.Forms.Button();
            this.removeLunchButton = new System.Windows.Forms.Button();
            this.removeIngredientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(891, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Meal Logger";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dinnerLabel
            // 
            this.dinnerLabel.AutoSize = true;
            this.dinnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.dinnerLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dinnerLabel.Location = new System.Drawing.Point(12, 120);
            this.dinnerLabel.Name = "dinnerLabel";
            this.dinnerLabel.Size = new System.Drawing.Size(75, 30);
            this.dinnerLabel.TabIndex = 1;
            this.dinnerLabel.Text = "Dinner";
            // 
            // lunchLabel
            // 
            this.lunchLabel.AutoSize = true;
            this.lunchLabel.BackColor = System.Drawing.Color.Transparent;
            this.lunchLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lunchLabel.Location = new System.Drawing.Point(347, 120);
            this.lunchLabel.Name = "lunchLabel";
            this.lunchLabel.Size = new System.Drawing.Size(69, 30);
            this.lunchLabel.TabIndex = 2;
            this.lunchLabel.Text = "Lunch";
            // 
            // LoLabel
            // 
            this.LoLabel.AutoSize = true;
            this.LoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoLabel.Location = new System.Drawing.Point(676, 120);
            this.LoLabel.Name = "LoLabel";
            this.LoLabel.Size = new System.Drawing.Size(204, 30);
            this.LoLabel.TabIndex = 3;
            this.LoLabel.Text = "Leftover Ingredients ";
            // 
            // dinnerListBox
            // 
            this.dinnerListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dinnerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dinnerListBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerListBox.ForeColor = System.Drawing.Color.Black;
            this.dinnerListBox.FormattingEnabled = true;
            this.dinnerListBox.ItemHeight = 21;
            this.dinnerListBox.Location = new System.Drawing.Point(17, 165);
            this.dinnerListBox.Name = "dinnerListBox";
            this.dinnerListBox.Size = new System.Drawing.Size(187, 212);
            this.dinnerListBox.TabIndex = 4;
            // 
            // lunchListBox
            // 
            this.lunchListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lunchListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lunchListBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchListBox.ForeColor = System.Drawing.Color.Black;
            this.lunchListBox.FormattingEnabled = true;
            this.lunchListBox.ItemHeight = 21;
            this.lunchListBox.Location = new System.Drawing.Point(349, 165);
            this.lunchListBox.Name = "lunchListBox";
            this.lunchListBox.Size = new System.Drawing.Size(187, 212);
            this.lunchListBox.TabIndex = 5;
            this.lunchListBox.SelectedIndexChanged += new System.EventHandler(this.lunchListBox_SelectedIndexChanged);
            // 
            // loListBox
            // 
            this.loListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loListBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loListBox.ForeColor = System.Drawing.Color.Black;
            this.loListBox.FormattingEnabled = true;
            this.loListBox.ItemHeight = 21;
            this.loListBox.Location = new System.Drawing.Point(681, 165);
            this.loListBox.Name = "loListBox";
            this.loListBox.Size = new System.Drawing.Size(187, 212);
            this.loListBox.TabIndex = 6;
            // 
            // addMealButton
            // 
            this.addMealButton.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMealButton.ForeColor = System.Drawing.Color.Red;
            this.addMealButton.Location = new System.Drawing.Point(357, 454);
            this.addMealButton.Name = "addMealButton";
            this.addMealButton.Size = new System.Drawing.Size(176, 54);
            this.addMealButton.TabIndex = 7;
            this.addMealButton.Text = "Add Meal";
            this.addMealButton.UseVisualStyleBackColor = true;
            this.addMealButton.Click += new System.EventHandler(this.addMealButton_Click);
            // 
            // deleteDinnerButton
            // 
            this.deleteDinnerButton.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDinnerButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteDinnerButton.Location = new System.Drawing.Point(17, 383);
            this.deleteDinnerButton.Name = "deleteDinnerButton";
            this.deleteDinnerButton.Size = new System.Drawing.Size(145, 38);
            this.deleteDinnerButton.TabIndex = 10;
            this.deleteDinnerButton.Text = "Remove Dinner";
            this.deleteDinnerButton.UseVisualStyleBackColor = true;
            this.deleteDinnerButton.Click += new System.EventHandler(this.deleteDinnerButton_Click);
            // 
            // removeLunchButton
            // 
            this.removeLunchButton.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLunchButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.removeLunchButton.Location = new System.Drawing.Point(349, 383);
            this.removeLunchButton.Name = "removeLunchButton";
            this.removeLunchButton.Size = new System.Drawing.Size(145, 38);
            this.removeLunchButton.TabIndex = 11;
            this.removeLunchButton.Text = "Remove Lunch";
            this.removeLunchButton.UseVisualStyleBackColor = true;
            this.removeLunchButton.Click += new System.EventHandler(this.removeLunchButton_Click);
            // 
            // removeIngredientButton
            // 
            this.removeIngredientButton.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIngredientButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.removeIngredientButton.Location = new System.Drawing.Point(681, 383);
            this.removeIngredientButton.Name = "removeIngredientButton";
            this.removeIngredientButton.Size = new System.Drawing.Size(145, 38);
            this.removeIngredientButton.TabIndex = 12;
            this.removeIngredientButton.Text = "Remove Ingredient";
            this.removeIngredientButton.UseVisualStyleBackColor = true;
            this.removeIngredientButton.Click += new System.EventHandler(this.removeIngredientButton_Click);
            // 
            // MealLoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::MealForm.Properties.Resources.pexels_henry___co_2341290;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 520);
            this.Controls.Add(this.removeIngredientButton);
            this.Controls.Add(this.removeLunchButton);
            this.Controls.Add(this.deleteDinnerButton);
            this.Controls.Add(this.addMealButton);
            this.Controls.Add(this.loListBox);
            this.Controls.Add(this.lunchListBox);
            this.Controls.Add(this.dinnerListBox);
            this.Controls.Add(this.LoLabel);
            this.Controls.Add(this.lunchLabel);
            this.Controls.Add(this.dinnerLabel);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MealLoggerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meal Logger";
            this.Load += new System.EventHandler(this.MealLoggerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label dinnerLabel;
        private System.Windows.Forms.Label lunchLabel;
        private System.Windows.Forms.Label LoLabel;
        private System.Windows.Forms.ListBox dinnerListBox;
        private System.Windows.Forms.ListBox lunchListBox;
        private System.Windows.Forms.ListBox loListBox;
        private System.Windows.Forms.Button addMealButton;
        private System.Windows.Forms.Button deleteDinnerButton;
        private System.Windows.Forms.Button removeLunchButton;
        private System.Windows.Forms.Button removeIngredientButton;
    }
}

