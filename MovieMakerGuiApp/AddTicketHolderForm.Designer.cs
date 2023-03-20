
namespace MovieMakerGuiApp
{
    partial class AddTicketHolderForm
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
            this.lblAddNewTicketHolder = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.rbnPaymentCash = new System.Windows.Forms.RadioButton();
            this.lblNumberofTickets = new System.Windows.Forms.Label();
            this.nudNoTickets = new System.Windows.Forms.NumericUpDown();
            this.rbnPaymentCard = new System.Windows.Forms.RadioButton();
            this.btnSnackBar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddNewTicketHolder
            // 
            this.lblAddNewTicketHolder.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewTicketHolder.Location = new System.Drawing.Point(12, 9);
            this.lblAddNewTicketHolder.Name = "lblAddNewTicketHolder";
            this.lblAddNewTicketHolder.Size = new System.Drawing.Size(776, 89);
            this.lblAddNewTicketHolder.TabIndex = 0;
            this.lblAddNewTicketHolder.Text = "Add New Ticket Holder";
            this.lblAddNewTicketHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter The Ticket Holders Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(13, 135);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(156, 20);
            this.tbxName.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 184);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(148, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Enter The Ticket Holders Age";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(10, 314);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(126, 13);
            this.lblPaymentMethod.TabIndex = 5;
            this.lblPaymentMethod.Text = "Choose Payment Method";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(12, 200);
            this.nudAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(156, 20);
            this.nudAge.TabIndex = 6;
            this.nudAge.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // rbnPaymentCash
            // 
            this.rbnPaymentCash.AutoSize = true;
            this.rbnPaymentCash.Location = new System.Drawing.Point(12, 330);
            this.rbnPaymentCash.Name = "rbnPaymentCash";
            this.rbnPaymentCash.Size = new System.Drawing.Size(49, 17);
            this.rbnPaymentCash.TabIndex = 7;
            this.rbnPaymentCash.TabStop = true;
            this.rbnPaymentCash.Text = "Cash";
            this.rbnPaymentCash.UseVisualStyleBackColor = true;
            // 
            // lblNumberofTickets
            // 
            this.lblNumberofTickets.AutoSize = true;
            this.lblNumberofTickets.Location = new System.Drawing.Point(12, 249);
            this.lblNumberofTickets.Name = "lblNumberofTickets";
            this.lblNumberofTickets.Size = new System.Drawing.Size(208, 13);
            this.lblNumberofTickets.TabIndex = 8;
            this.lblNumberofTickets.Text = "Enter The Number of Tickets To Purchase";
            // 
            // numericUpDown1
            // 
            this.nudNoTickets.Location = new System.Drawing.Point(12, 265);
            this.nudNoTickets.Name = "numericUpDown1";
            this.nudNoTickets.Size = new System.Drawing.Size(157, 20);
            this.nudNoTickets.TabIndex = 9;
            // 
            // rbnPaymentCard
            // 
            this.rbnPaymentCard.AutoSize = true;
            this.rbnPaymentCard.Location = new System.Drawing.Point(78, 330);
            this.rbnPaymentCard.Name = "rbnPaymentCard";
            this.rbnPaymentCard.Size = new System.Drawing.Size(47, 17);
            this.rbnPaymentCard.TabIndex = 10;
            this.rbnPaymentCard.TabStop = true;
            this.rbnPaymentCard.Text = "Card";
            this.rbnPaymentCard.UseVisualStyleBackColor = true;
            // 
            // btnSnackBar
            // 
            this.btnSnackBar.Location = new System.Drawing.Point(12, 377);
            this.btnSnackBar.Name = "btnSnackBar";
            this.btnSnackBar.Size = new System.Drawing.Size(156, 43);
            this.btnSnackBar.TabIndex = 11;
            this.btnSnackBar.Text = "Continue To The Snack Bar";
            this.btnSnackBar.UseVisualStyleBackColor = true;
            this.btnSnackBar.Click += new System.EventHandler(this.btnSnackBar_Click);
            // 
            // AddTicketHolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSnackBar);
            this.Controls.Add(this.rbnPaymentCard);
            this.Controls.Add(this.nudNoTickets);
            this.Controls.Add(this.lblNumberofTickets);
            this.Controls.Add(this.rbnPaymentCash);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddNewTicketHolder);
            this.Name = "AddTicketHolderForm";
            this.Text = "AddTicketHolderForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewTicketHolder;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.RadioButton rbnPaymentCash;
        private System.Windows.Forms.Label lblNumberofTickets;
        private System.Windows.Forms.NumericUpDown nudNoTickets;
        private System.Windows.Forms.RadioButton rbnPaymentCard;
        private System.Windows.Forms.Button btnSnackBar;
    }
}