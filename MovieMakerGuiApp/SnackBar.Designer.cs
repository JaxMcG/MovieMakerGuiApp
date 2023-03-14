
namespace MovieMakerGuiApp
{
    partial class SnackBar
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
            this.lblSnackBar = new System.Windows.Forms.Label();
            this.lblSnackItem = new System.Windows.Forms.Label();
            this.lblDrinkItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSnacksAvailable = new System.Windows.Forms.ComboBox();
            this.cbxDrinksAvailable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSnackBar
            // 
            this.lblSnackBar.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnackBar.Location = new System.Drawing.Point(3, 9);
            this.lblSnackBar.Name = "lblSnackBar";
            this.lblSnackBar.Size = new System.Drawing.Size(776, 85);
            this.lblSnackBar.TabIndex = 0;
            this.lblSnackBar.Text = "Snack Bar";
            this.lblSnackBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSnackItem
            // 
            this.lblSnackItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnackItem.Location = new System.Drawing.Point(12, 117);
            this.lblSnackItem.Name = "lblSnackItem";
            this.lblSnackItem.Size = new System.Drawing.Size(293, 20);
            this.lblSnackItem.TabIndex = 1;
            this.lblSnackItem.Text = "Snacks";
            this.lblSnackItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDrinkItem
            // 
            this.lblDrinkItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkItem.Location = new System.Drawing.Point(495, 117);
            this.lblDrinkItem.Name = "lblDrinkItem";
            this.lblDrinkItem.Size = new System.Drawing.Size(293, 20);
            this.lblDrinkItem.TabIndex = 2;
            this.lblDrinkItem.Text = "Drinks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // cbxSnacksAvailable
            // 
            this.cbxSnacksAvailable.FormattingEnabled = true;
            this.cbxSnacksAvailable.Location = new System.Drawing.Point(211, 141);
            this.cbxSnacksAvailable.Name = "cbxSnacksAvailable";
            this.cbxSnacksAvailable.Size = new System.Drawing.Size(121, 21);
            this.cbxSnacksAvailable.TabIndex = 4;
            // 
            // cbxDrinksAvailable
            // 
            this.cbxDrinksAvailable.FormattingEnabled = true;
            this.cbxDrinksAvailable.Location = new System.Drawing.Point(464, 141);
            this.cbxDrinksAvailable.Name = "cbxDrinksAvailable";
            this.cbxDrinksAvailable.Size = new System.Drawing.Size(121, 21);
            this.cbxDrinksAvailable.TabIndex = 5;
            // 
            // SnackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxDrinksAvailable);
            this.Controls.Add(this.cbxSnacksAvailable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDrinkItem);
            this.Controls.Add(this.lblSnackItem);
            this.Controls.Add(this.lblSnackBar);
            this.Name = "SnackBar";
            this.Text = "SnackBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSnackBar;
        private System.Windows.Forms.Label lblSnackItem;
        private System.Windows.Forms.Label lblDrinkItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSnacksAvailable;
        private System.Windows.Forms.ComboBox cbxDrinksAvailable;
    }
}