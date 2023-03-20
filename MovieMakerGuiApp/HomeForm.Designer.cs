
namespace MovieMakerGuiApp
{
    partial class HomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.btnAddTicketHolder = new System.Windows.Forms.Button();
            this.btnViewSaleStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold);
            this.lblHomeTitle.Location = new System.Drawing.Point(12, 9);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(776, 116);
            this.lblHomeTitle.TabIndex = 1;
            this.lblHomeTitle.Text = "Movie Maker App";
            this.lblHomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddTicketHolder
            // 
            this.btnAddTicketHolder.Location = new System.Drawing.Point(324, 146);
            this.btnAddTicketHolder.Name = "btnAddTicketHolder";
            this.btnAddTicketHolder.Size = new System.Drawing.Size(138, 54);
            this.btnAddTicketHolder.TabIndex = 2;
            this.btnAddTicketHolder.Text = "Add Ticket Holder";
            this.btnAddTicketHolder.UseVisualStyleBackColor = true;
            this.btnAddTicketHolder.Click += new System.EventHandler(this.btnAddTicketHolder_Click);
            // 
            // btnViewSaleStats
            // 
            this.btnViewSaleStats.Location = new System.Drawing.Point(324, 206);
            this.btnViewSaleStats.Name = "btnViewSaleStats";
            this.btnViewSaleStats.Size = new System.Drawing.Size(138, 54);
            this.btnViewSaleStats.TabIndex = 3;
            this.btnViewSaleStats.Text = "View Sale Stats";
            this.btnViewSaleStats.UseVisualStyleBackColor = true;
            this.btnViewSaleStats.Click += new System.EventHandler(this.btnViewSaleStats_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewSaleStats);
            this.Controls.Add(this.btnAddTicketHolder);
            this.Controls.Add(this.lblHomeTitle);
            this.Controls.Add(this.label1);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Button btnAddTicketHolder;
        private System.Windows.Forms.Button btnViewSaleStats;
    }
}

