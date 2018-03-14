namespace Wage_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noOneTextBox = new System.Windows.Forms.TextBox();
            this.noTwoTextBox = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter No.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter No.2";
            // 
            // noOneTextBox
            // 
            this.noOneTextBox.Location = new System.Drawing.Point(146, 17);
            this.noOneTextBox.Name = "noOneTextBox";
            this.noOneTextBox.Size = new System.Drawing.Size(100, 20);
            this.noOneTextBox.TabIndex = 2;
            this.noOneTextBox.Text = "40";
            // 
            // noTwoTextBox
            // 
            this.noTwoTextBox.Location = new System.Drawing.Point(146, 43);
            this.noTwoTextBox.Name = "noTwoTextBox";
            this.noTwoTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTwoTextBox.TabIndex = 3;
            this.noTwoTextBox.Text = "9.65";
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(64, 88);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(75, 36);
            this.Sum.TabIndex = 4;
            this.Sum.Text = "Calculate Sum";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.calcGrossPayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(145, 88);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 139);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.noTwoTextBox);
            this.Controls.Add(this.noOneTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noOneTextBox;
        private System.Windows.Forms.TextBox noTwoTextBox;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button exitButton;
    }
}

