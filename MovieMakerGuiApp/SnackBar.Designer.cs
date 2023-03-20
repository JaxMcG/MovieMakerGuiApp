
using System.Collections.Generic;

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
            int tabIndex = 0;
            //Initialising Controls

            this.lblSnackBar = new System.Windows.Forms.Label();
            this.lblSnackItem = new System.Windows.Forms.Label();
            this.snackItems = new List<System.Windows.Forms.Label>();
            this.lblDrinkItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.nudPopcornQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPopcorn = new System.Windows.Forms.Label();
            this.nudChipsQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudChocolateQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblChips = new System.Windows.Forms.Label();
            this.lblChocolate = new System.Windows.Forms.Label();
            this.lblFanta = new System.Windows.Forms.Label();
            this.nudFantaQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblLnP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudLnPQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopcornQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipsQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChocolateQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFantaQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLnPQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSnackBar
            // 
            this.lblSnackBar.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnackBar.Location = new System.Drawing.Point(3, 9);
            this.lblSnackBar.Name = "lblSnackBar";
            this.lblSnackBar.Size = new System.Drawing.Size(776, 85);
            this.lblSnackBar.TabIndex = tabIndex;
            tabIndex++;
            this.lblSnackBar.Text = "Snack Bar";
            this.lblSnackBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSnackItems
            // 

            int lblSnackY = 65;

            foreach (var item in tm.GetAvailableSnacks())
            {
                snackItems.Add(new System.Windows.Forms.Label());
                lblSnackY += 25;

                this.snackItems[snackItems.Count-1].AutoSize = true;
                this.snackItems[snackItems.Count - 1].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.snackItems[snackItems.Count - 1].Location = new System.Drawing.Point(12, lblSnackY);
                this.snackItems[snackItems.Count - 1].Name = $"lbl{item}";
                this.snackItems[snackItems.Count - 1].Size = new System.Drawing.Size(293, 20);
                this.snackItems[snackItems.Count - 1].TabIndex = tabIndex;
                tabIndex++;
                this.snackItems[snackItems.Count - 1].Text = item;
                this.snackItems[snackItems.Count - 1].TextAlign = System.Drawing.ContentAlignment.TopRight;
            }

            this.lblSnackItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnackItem.Location = new System.Drawing.Point(12, 117);
            this.lblSnackItem.Name = "lblSnackItem";
            this.lblSnackItem.Size = new System.Drawing.Size(293, 20);
            this.lblSnackItem.TabIndex = tabIndex;
            tabIndex++;
            this.lblSnackItem.Text = "Snacks";
            this.lblSnackItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDrinkItem
            // 
            this.lblDrinkItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkItem.Location = new System.Drawing.Point(495, 117);
            this.lblDrinkItem.Name = "lblDrinkItem";
            this.lblDrinkItem.Size = new System.Drawing.Size(293, 20);
            this.lblDrinkItem.TabIndex = tabIndex;
            tabIndex++;
            this.lblDrinkItem.Text = "Drinks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = tabIndex;
            tabIndex++;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(338, 331);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 41);
            this.btnCheckout.TabIndex = tabIndex;
            tabIndex++;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // nudPopcornQuantity
            // 
            this.nudPopcornQuantity.Location = new System.Drawing.Point(260, 146);
            this.nudPopcornQuantity.Name = "nudPopcornQuantity";
            this.nudPopcornQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudPopcornQuantity.TabIndex = tabIndex;
            tabIndex++;
            // 
            // lblPopcorn
            // 
            this.lblPopcorn.AutoSize = true;
            this.lblPopcorn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopcorn.Location = new System.Drawing.Point(185, 145);
            this.lblPopcorn.Name = "lblPopcorn";
            this.lblPopcorn.Size = new System.Drawing.Size(59, 18);
            this.lblPopcorn.TabIndex = tabIndex;
            tabIndex++;
            this.lblPopcorn.Text = "Popcorn";
            // 
            // nudChipsQuantity
            // 
            this.nudChipsQuantity.Location = new System.Drawing.Point(260, 172);
            this.nudChipsQuantity.Name = "nudChipsQuantity";
            this.nudChipsQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudChipsQuantity.TabIndex = tabIndex;
            tabIndex++;
            // 
            // nudChocolateQuantity
            // 
            this.nudChocolateQuantity.Location = new System.Drawing.Point(260, 198);
            this.nudChocolateQuantity.Name = "nudChocolateQuantity";
            this.nudChocolateQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudChocolateQuantity.TabIndex = tabIndex;
            tabIndex++;
            // 
            // lblChips
            // 
            this.lblChips.AutoSize = true;
            this.lblChips.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChips.Location = new System.Drawing.Point(185, 171);
            this.lblChips.Name = "lblChips";
            this.lblChips.Size = new System.Drawing.Size(43, 18);
            this.lblChips.TabIndex = tabIndex;
            tabIndex++;
            this.lblChips.Text = "Chips";
            // 
            // lblChocolate
            // 
            this.lblChocolate.AutoSize = true;
            this.lblChocolate.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChocolate.Location = new System.Drawing.Point(185, 197);
            this.lblChocolate.Name = "lblChocolate";
            this.lblChocolate.Size = new System.Drawing.Size(69, 18);
            this.lblChocolate.TabIndex = tabIndex;
            tabIndex++;
            this.lblChocolate.Text = "Chocolate";
            // 
            // lblFanta
            // 
            this.lblFanta.AutoSize = true;
            this.lblFanta.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFanta.Location = new System.Drawing.Point(452, 145);
            this.lblFanta.Name = "lblFanta";
            this.lblFanta.Size = new System.Drawing.Size(42, 18);
            this.lblFanta.TabIndex = tabIndex;
            tabIndex++;
            this.lblFanta.Text = "Fanta";
            // 
            // nudFantaQuantity
            // 
            this.nudFantaQuantity.Location = new System.Drawing.Point(517, 143);
            this.nudFantaQuantity.Name = "nudFantaQuantity";
            this.nudFantaQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudFantaQuantity.TabIndex = tabIndex;
            tabIndex++;
            // 
            // lblLnP
            // 
            this.lblLnP.AutoSize = true;
            this.lblLnP.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLnP.Location = new System.Drawing.Point(452, 171);
            this.lblLnP.Name = "lblLnP";
            this.lblLnP.Size = new System.Drawing.Size(32, 18);
            this.lblLnP.TabIndex = tabIndex;
            tabIndex++;
            this.lblLnP.Text = "LnP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = tabIndex;
            tabIndex++;
            // 
            // nudLnPQuantity
            // 
            this.nudLnPQuantity.Location = new System.Drawing.Point(517, 169);
            this.nudLnPQuantity.Name = "nudLnPQuantity";
            this.nudLnPQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudLnPQuantity.TabIndex = tabIndex;
            tabIndex++;
            // 
            // SnackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudLnPQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLnP);
            this.Controls.Add(this.nudFantaQuantity);
            this.Controls.Add(this.lblFanta);
            this.Controls.Add(this.lblChocolate);
            this.Controls.Add(this.lblChips);
            this.Controls.Add(this.nudChocolateQuantity);
            this.Controls.Add(this.nudChipsQuantity);
            this.Controls.Add(this.lblPopcorn);
            this.Controls.Add(this.nudPopcornQuantity);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDrinkItem);
            this.Controls.Add(this.lblSnackItem);
            this.Controls.Add(this.lblSnackBar);
            this.Name = "SnackBar";
            this.Text = "SnackBar";
            ((System.ComponentModel.ISupportInitialize)(this.nudPopcornQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipsQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChocolateQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFantaQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLnPQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Declaring Controls
        private System.Windows.Forms.Label lblSnackBar;
        private System.Windows.Forms.Label lblSnackItem;
        private List<System.Windows.Forms.Label> snackItems;
        private System.Windows.Forms.Label lblDrinkItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.NumericUpDown nudPopcornQuantity;
        private System.Windows.Forms.Label lblPopcorn;
        private System.Windows.Forms.NumericUpDown nudChipsQuantity;
        private System.Windows.Forms.NumericUpDown nudChocolateQuantity;
        private System.Windows.Forms.Label lblChips;
        private System.Windows.Forms.Label lblChocolate;
        private System.Windows.Forms.Label lblFanta;
        private System.Windows.Forms.NumericUpDown nudFantaQuantity;
        private System.Windows.Forms.Label lblLnP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudLnPQuantity;
    }
}