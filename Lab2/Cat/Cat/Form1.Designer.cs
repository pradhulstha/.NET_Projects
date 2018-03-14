namespace Cat
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
            this.dogPictureBox = new System.Windows.Forms.PictureBox();
            this.catPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the Cat!";
            // 
            // dogPictureBox
            // 
            this.dogPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dogPictureBox.Image = global::Cat.Properties.Resources.dog;
            this.dogPictureBox.Location = new System.Drawing.Point(330, 38);
            this.dogPictureBox.Name = "dogPictureBox";
            this.dogPictureBox.Size = new System.Drawing.Size(229, 216);
            this.dogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dogPictureBox.TabIndex = 2;
            this.dogPictureBox.TabStop = false;
            this.dogPictureBox.Click += new System.EventHandler(this.dogPictureBox_Click_1);
            // 
            // catPictureBox
            // 
            this.catPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catPictureBox.Image = global::Cat.Properties.Resources.Cat;
            this.catPictureBox.Location = new System.Drawing.Point(16, 38);
            this.catPictureBox.Name = "catPictureBox";
            this.catPictureBox.Size = new System.Drawing.Size(229, 216);
            this.catPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catPictureBox.TabIndex = 0;
            this.catPictureBox.TabStop = false;
            this.catPictureBox.Click += new System.EventHandler(this.catPictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Click the Dog!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dogPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catPictureBox);
            this.Name = "Form1";
            this.Text = "Cat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox catPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox dogPictureBox;
        private System.Windows.Forms.Label label2;
    }
}

