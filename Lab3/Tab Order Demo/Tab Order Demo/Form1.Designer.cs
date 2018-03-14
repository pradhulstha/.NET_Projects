namespace Tab_Order_Demo
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
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.promptNameLabel = new System.Windows.Forms.Label();
            this.promptAddressLabel = new System.Windows.Forms.Label();
            this.promptCityLabel = new System.Windows.Forms.Label();
            this.promptStateLabel = new System.Windows.Forms.Label();
            this.promptZipLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(182, 124);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(196, 31);
            this.cityTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(182, 73);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(196, 31);
            this.addressTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(182, 29);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 31);
            this.nameTextBox.TabIndex = 0;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(182, 173);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(196, 31);
            this.stateTextBox.TabIndex = 4;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(182, 223);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(196, 31);
            this.zipTextBox.TabIndex = 5;
            // 
            // promptNameLabel
            // 
            this.promptNameLabel.AutoSize = true;
            this.promptNameLabel.Location = new System.Drawing.Point(82, 29);
            this.promptNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.promptNameLabel.Name = "promptNameLabel";
            this.promptNameLabel.Size = new System.Drawing.Size(74, 25);
            this.promptNameLabel.TabIndex = 5;
            this.promptNameLabel.Text = "Name:";
            // 
            // promptAddressLabel
            // 
            this.promptAddressLabel.AutoSize = true;
            this.promptAddressLabel.Location = new System.Drawing.Point(62, 77);
            this.promptAddressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.promptAddressLabel.Name = "promptAddressLabel";
            this.promptAddressLabel.Size = new System.Drawing.Size(97, 25);
            this.promptAddressLabel.TabIndex = 7;
            this.promptAddressLabel.Text = "Address:";
            // 
            // promptCityLabel
            // 
            this.promptCityLabel.AutoSize = true;
            this.promptCityLabel.Location = new System.Drawing.Point(104, 129);
            this.promptCityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.promptCityLabel.Name = "promptCityLabel";
            this.promptCityLabel.Size = new System.Drawing.Size(55, 25);
            this.promptCityLabel.TabIndex = 6;
            this.promptCityLabel.Text = "City:";
            // 
            // promptStateLabel
            // 
            this.promptStateLabel.AutoSize = true;
            this.promptStateLabel.Location = new System.Drawing.Point(88, 181);
            this.promptStateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.promptStateLabel.Name = "promptStateLabel";
            this.promptStateLabel.Size = new System.Drawing.Size(68, 25);
            this.promptStateLabel.TabIndex = 9;
            this.promptStateLabel.Text = "State:";
            // 
            // promptZipLabel
            // 
            this.promptZipLabel.AutoSize = true;
            this.promptZipLabel.Location = new System.Drawing.Point(104, 229);
            this.promptZipLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.promptZipLabel.Name = "promptZipLabel";
            this.promptZipLabel.Size = new System.Drawing.Size(50, 25);
            this.promptZipLabel.TabIndex = 10;
            this.promptZipLabel.Text = "ZIP:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(87, 301);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 44);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(187, 29);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 25);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Visible = false;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(187, 79);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(0, 25);
            this.addressLabel.TabIndex = 12;
            this.addressLabel.Visible = false;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(186, 130);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(0, 25);
            this.cityLabel.TabIndex = 13;
            this.cityLabel.Visible = false;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(186, 176);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(0, 25);
            this.stateLabel.TabIndex = 14;
            this.stateLabel.Visible = false;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(187, 222);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(0, 25);
            this.zipLabel.TabIndex = 15;
            this.zipLabel.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(266, 301);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 44);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 377);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.promptZipLabel);
            this.Controls.Add(this.promptStateLabel);
            this.Controls.Add(this.promptCityLabel);
            this.Controls.Add(this.promptAddressLabel);
            this.Controls.Add(this.promptNameLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Tab Order Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label promptNameLabel;
        private System.Windows.Forms.Label promptAddressLabel;
        private System.Windows.Forms.Label promptCityLabel;
        private System.Windows.Forms.Label promptStateLabel;
        private System.Windows.Forms.Label promptZipLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

