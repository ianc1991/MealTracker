
namespace MealForm
{
    partial class AddLeftOver
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
            this.loNameText = new System.Windows.Forms.TextBox();
            this.loName = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loNameText
            // 
            this.loNameText.BackColor = System.Drawing.Color.White;
            this.loNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loNameText.Location = new System.Drawing.Point(172, 25);
            this.loNameText.Name = "loNameText";
            this.loNameText.Size = new System.Drawing.Size(212, 26);
            this.loNameText.TabIndex = 5;
            // 
            // loName
            // 
            this.loName.AutoSize = true;
            this.loName.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loName.Location = new System.Drawing.Point(11, 19);
            this.loName.Name = "loName";
            this.loName.Size = new System.Drawing.Size(155, 30);
            this.loName.TabIndex = 4;
            this.loName.Text = "Leftover Name:";
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngredientButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addIngredientButton.Location = new System.Drawing.Point(194, 57);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(145, 38);
            this.addIngredientButton.TabIndex = 13;
            this.addIngredientButton.Text = "Add Ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // AddLeftOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(515, 107);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.loNameText);
            this.Controls.Add(this.loName);
            this.MaximizeBox = false;
            this.Name = "AddLeftOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Leftovers";
            this.Load += new System.EventHandler(this.AddLeftOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loNameText;
        private System.Windows.Forms.Label loName;
        private System.Windows.Forms.Button addIngredientButton;
    }
}