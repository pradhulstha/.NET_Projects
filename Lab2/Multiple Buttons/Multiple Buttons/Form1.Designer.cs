namespace Multiple_Buttons
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
            this.firstButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.thirdButton = new System.Windows.Forms.Button();
            this.fourthButton = new System.Windows.Forms.Button();
            this.fifthButton = new System.Windows.Forms.Button();
            this.sixthButton = new System.Windows.Forms.Button();
            this.seventhButton = new System.Windows.Forms.Button();
            this.eigthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(44, 48);
            this.firstButton.Margin = new System.Windows.Forms.Padding(6);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(180, 44);
            this.firstButton.TabIndex = 0;
            this.firstButton.Text = "First Button";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(236, 48);
            this.secondButton.Margin = new System.Windows.Forms.Padding(6);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(180, 44);
            this.secondButton.TabIndex = 1;
            this.secondButton.Text = "Second Button";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
            // 
            // thirdButton
            // 
            this.thirdButton.Location = new System.Drawing.Point(428, 48);
            this.thirdButton.Margin = new System.Windows.Forms.Padding(6);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(180, 44);
            this.thirdButton.TabIndex = 2;
            this.thirdButton.Text = "Third Button";
            this.thirdButton.UseVisualStyleBackColor = true;
            this.thirdButton.Click += new System.EventHandler(this.thirdButton_Click);
            // 
            // fourthButton
            // 
            this.fourthButton.Location = new System.Drawing.Point(44, 187);
            this.fourthButton.Margin = new System.Windows.Forms.Padding(6);
            this.fourthButton.Name = "fourthButton";
            this.fourthButton.Size = new System.Drawing.Size(180, 44);
            this.fourthButton.TabIndex = 3;
            this.fourthButton.Text = "Fourth Button";
            this.fourthButton.UseVisualStyleBackColor = true;
            this.fourthButton.Click += new System.EventHandler(this.fourthButton_Click);
            // 
            // fifthButton
            // 
            this.fifthButton.Location = new System.Drawing.Point(266, 187);
            this.fifthButton.Margin = new System.Windows.Forms.Padding(6);
            this.fifthButton.Name = "fifthButton";
            this.fifthButton.Size = new System.Drawing.Size(150, 44);
            this.fifthButton.TabIndex = 4;
            this.fifthButton.Text = "Fifth Button";
            this.fifthButton.UseVisualStyleBackColor = true;
            this.fifthButton.Click += new System.EventHandler(this.fifthButton_Click);
            // 
            // sixthButton
            // 
            this.sixthButton.Location = new System.Drawing.Point(458, 187);
            this.sixthButton.Margin = new System.Windows.Forms.Padding(6);
            this.sixthButton.Name = "sixthButton";
            this.sixthButton.Size = new System.Drawing.Size(150, 44);
            this.sixthButton.TabIndex = 5;
            this.sixthButton.Text = "Sixth Button";
            this.sixthButton.UseVisualStyleBackColor = true;
            this.sixthButton.Click += new System.EventHandler(this.sixthButton_Click);
            // 
            // button2
            // 
            this.seventhButton.Location = new System.Drawing.Point(44, 317);
            this.seventhButton.Margin = new System.Windows.Forms.Padding(6);
            this.seventhButton.Name = "button2";
            this.seventhButton.Size = new System.Drawing.Size(180, 44);
            this.seventhButton.TabIndex = 6;
            this.seventhButton.Text = "Seventh Button";
            this.seventhButton.UseVisualStyleBackColor = true;
            this.seventhButton.Click += new System.EventHandler(this.seventhButton_Click);

            // 
            // button3
            // 
            this.eigthButton.Location = new System.Drawing.Point(266, 317);
            this.eigthButton.Margin = new System.Windows.Forms.Padding(6);
            this.eigthButton.Name = "button3";
            this.eigthButton.Size = new System.Drawing.Size(150, 44);
            this.eigthButton.TabIndex = 7;
            this.eigthButton.Text = "Eighth Button";
            this.eigthButton.UseVisualStyleBackColor = true;
            this.eigthButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 565);
            this.Controls.Add(this.eigthButton);
            this.Controls.Add(this.seventhButton);
            this.Controls.Add(this.sixthButton);
            this.Controls.Add(this.fifthButton);
            this.Controls.Add(this.fourthButton);
            this.Controls.Add(this.thirdButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Multiple Buttons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button thirdButton;
        private System.Windows.Forms.Button fourthButton;
        private System.Windows.Forms.Button fifthButton;
        private System.Windows.Forms.Button sixthButton;
        private System.Windows.Forms.Button seventhButton;
        private System.Windows.Forms.Button eigthButton;
    }
}

