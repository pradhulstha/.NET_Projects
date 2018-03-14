namespace Presidential_Trivia
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.showAnswerButton = new System.Windows.Forms.Button();
            this.infoPres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(24, 37);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(520, 73);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "What former U.S. president is known for going on an African safari?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(24, 148);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(518, 71);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Location = new System.Drawing.Point(170, 320);
            this.showAnswerButton.Margin = new System.Windows.Forms.Padding(6);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(220, 44);
            this.showAnswerButton.TabIndex = 2;
            this.showAnswerButton.Text = "Show the Answer";
            this.showAnswerButton.UseVisualStyleBackColor = true;
            this.showAnswerButton.Click += new System.EventHandler(this.showAnswerButton_Click);
            // 
            // infoPres
            // 
            this.infoPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPres.Location = new System.Drawing.Point(24, 230);
            this.infoPres.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.infoPres.Name = "infoPres";
            this.infoPres.Size = new System.Drawing.Size(520, 73);
            this.infoPres.TabIndex = 3;
            this.infoPres.Text = "He served as the 32nd President of the United States from 1933 until his death in" +
    " 1945";
            this.infoPres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoPres.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(568, 401);
            this.Controls.Add(this.infoPres);
            this.Controls.Add(this.showAnswerButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Presidential Trivia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button showAnswerButton;
        private System.Windows.Forms.Label infoPres;
    }
}

