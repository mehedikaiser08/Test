namespace EvenOddShortUI
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.oddButton = new System.Windows.Forms.Button();
            this.evenButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(112, 34);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(158, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(194, 61);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // oddButton
            // 
            this.oddButton.Location = new System.Drawing.Point(12, 124);
            this.oddButton.Name = "oddButton";
            this.oddButton.Size = new System.Drawing.Size(75, 23);
            this.oddButton.TabIndex = 1;
            this.oddButton.Text = "ODD";
            this.oddButton.UseVisualStyleBackColor = true;
            this.oddButton.Click += new System.EventHandler(this.oddButton_Click);
            // 
            // evenButton
            // 
            this.evenButton.Location = new System.Drawing.Point(93, 124);
            this.evenButton.Name = "evenButton";
            this.evenButton.Size = new System.Drawing.Size(75, 23);
            this.evenButton.TabIndex = 1;
            this.evenButton.Text = "EVEN";
            this.evenButton.UseVisualStyleBackColor = true;
            this.evenButton.Click += new System.EventHandler(this.evenButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(184, 124);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 1;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 181);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.evenButton);
            this.Controls.Add(this.oddButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberTextBox);
            this.Name = "Form1";
            this.Text = "NumberUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button oddButton;
        private System.Windows.Forms.Button evenButton;
        private System.Windows.Forms.Button showAllButton;
    }
}

