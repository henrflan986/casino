namespace casino
{
    partial class Form1
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
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.standbutton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.DealButton = new System.Windows.Forms.Button();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moneyBox
            // 
            this.moneyBox.Location = new System.Drawing.Point(219, 47);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(100, 20);
            this.moneyBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many chips would you like to bet";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(996, 197);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(56, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Your hand";
            // 
            // standbutton
            // 
            this.standbutton.Location = new System.Drawing.Point(916, 460);
            this.standbutton.Name = "standbutton";
            this.standbutton.Size = new System.Drawing.Size(75, 23);
            this.standbutton.TabIndex = 4;
            this.standbutton.Text = "Stand";
            this.standbutton.UseVisualStyleBackColor = true;
            this.standbutton.Click += new System.EventHandler(this.standbutton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(916, 504);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 23);
            this.hitButton.TabIndex = 5;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(821, 22);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(75, 23);
            this.DealButton.TabIndex = 6;
            this.DealButton.Text = "Deal cards";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Location = new System.Drawing.Point(708, 158);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(114, 13);
            this.dealerLabel.TabIndex = 7;
            this.dealerLabel.Text = "Dealers cards              ";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(840, 275);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(0, 13);
            this.textLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::casino.Properties.Resources.Blackjack_table;
            this.ClientSize = new System.Drawing.Size(1080, 607);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.standbutton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moneyBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button standbutton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label textLabel;
    }
}

