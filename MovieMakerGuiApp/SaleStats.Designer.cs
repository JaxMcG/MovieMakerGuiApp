
namespace MovieMakerGuiApp
{
    partial class SaleStats
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
            this.lblViewSaleStats = new System.Windows.Forms.Label();
            this.rbxSaleStats = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblViewSaleStats
            // 
            this.lblViewSaleStats.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewSaleStats.Location = new System.Drawing.Point(12, 9);
            this.lblViewSaleStats.Name = "lblViewSaleStats";
            this.lblViewSaleStats.Size = new System.Drawing.Size(776, 43);
            this.lblViewSaleStats.TabIndex = 0;
            this.lblViewSaleStats.Text = "Sale Stats";
            this.lblViewSaleStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbxSaleStats
            // 
            this.rbxSaleStats.Location = new System.Drawing.Point(12, 55);
            this.rbxSaleStats.Name = "rbxSaleStats";
            this.rbxSaleStats.Size = new System.Drawing.Size(310, 383);
            this.rbxSaleStats.TabIndex = 1;
            this.rbxSaleStats.Text = "";
            // 
            // SaleStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbxSaleStats);
            this.Controls.Add(this.lblViewSaleStats);
            this.Name = "SaleStats";
            this.Text = "SaleStats";
            this.Load += new System.EventHandler(this.SaleStats_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblViewSaleStats;
        private System.Windows.Forms.RichTextBox rbxSaleStats;
    }
}