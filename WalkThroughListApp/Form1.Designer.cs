namespace WalkThroughListApp
{
    partial class WalkThrouhWithListUI
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
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.showAllNumberButton = new System.Windows.Forms.Button();
            this.showAllNumberListBox = new System.Windows.Forms.ListBox();
            this.sumResultLabel = new System.Windows.Forms.Label();
            this.sumResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(111, 33);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(72, 13);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "Enter Number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(207, 30);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(240, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(372, 56);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showAllNumberButton
            // 
            this.showAllNumberButton.Location = new System.Drawing.Point(339, 85);
            this.showAllNumberButton.Name = "showAllNumberButton";
            this.showAllNumberButton.Size = new System.Drawing.Size(108, 23);
            this.showAllNumberButton.TabIndex = 3;
            this.showAllNumberButton.Text = "Show All Number";
            this.showAllNumberButton.UseVisualStyleBackColor = true;
            this.showAllNumberButton.Click += new System.EventHandler(this.showAllNumberButton_Click);
            // 
            // showAllNumberListBox
            // 
            this.showAllNumberListBox.FormattingEnabled = true;
            this.showAllNumberListBox.Location = new System.Drawing.Point(207, 114);
            this.showAllNumberListBox.Name = "showAllNumberListBox";
            this.showAllNumberListBox.Size = new System.Drawing.Size(240, 160);
            this.showAllNumberListBox.TabIndex = 4;
            // 
            // sumResultLabel
            // 
            this.sumResultLabel.AutoSize = true;
            this.sumResultLabel.Location = new System.Drawing.Point(111, 286);
            this.sumResultLabel.Name = "sumResultLabel";
            this.sumResultLabel.Size = new System.Drawing.Size(61, 13);
            this.sumResultLabel.TabIndex = 5;
            this.sumResultLabel.Text = "Sum Result";
            // 
            // sumResultTextBox
            // 
            this.sumResultTextBox.Location = new System.Drawing.Point(207, 283);
            this.sumResultTextBox.Name = "sumResultTextBox";
            this.sumResultTextBox.Size = new System.Drawing.Size(240, 20);
            this.sumResultTextBox.TabIndex = 6;
            // 
            // WalkThrouhWithListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 363);
            this.Controls.Add(this.sumResultTextBox);
            this.Controls.Add(this.sumResultLabel);
            this.Controls.Add(this.showAllNumberListBox);
            this.Controls.Add(this.showAllNumberButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Name = "WalkThrouhWithListUI";
            this.Text = "Walk Thorugh With List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showAllNumberButton;
        private System.Windows.Forms.ListBox showAllNumberListBox;
        private System.Windows.Forms.Label sumResultLabel;
        private System.Windows.Forms.TextBox sumResultTextBox;
    }
}

