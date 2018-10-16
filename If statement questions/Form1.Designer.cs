namespace If_statement_questions
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
            this.colorLabel = new System.Windows.Forms.Label();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.colorInput = new System.Windows.Forms.TextBox();
            this.shapeInput = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(137, 108);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(144, 13);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "Enter r for Red or g for Green";
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(137, 162);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(194, 13);
            this.shapeLabel.TabIndex = 1;
            this.shapeLabel.Text = "Enter a Shape(either rectangle or circle)";
            // 
            // colorInput
            // 
            this.colorInput.Location = new System.Drawing.Point(390, 108);
            this.colorInput.Name = "colorInput";
            this.colorInput.Size = new System.Drawing.Size(23, 20);
            this.colorInput.TabIndex = 2;
            // 
            // shapeInput
            // 
            this.shapeInput.Location = new System.Drawing.Point(390, 162);
            this.shapeInput.Name = "shapeInput";
            this.shapeInput.Size = new System.Drawing.Size(130, 20);
            this.shapeInput.TabIndex = 3;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(604, 226);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(141, 49);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.shapeInput);
            this.Controls.Add(this.colorInput);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.colorLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.TextBox colorInput;
        private System.Windows.Forms.TextBox shapeInput;
        private System.Windows.Forms.Button enterButton;
    }
}

