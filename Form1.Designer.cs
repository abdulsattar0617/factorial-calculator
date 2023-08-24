namespace Factorial_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headingLabel = new Label();
            nValue = new TextBox();
            calculateButton = new Button();
            answerValue = new TextBox();
            answerLabel = new Label();
            resetButton = new Button();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.BackColor = Color.Transparent;
            headingLabel.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            headingLabel.Location = new Point(20, 9);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(273, 29);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Factorial Calculator";
            // 
            // nValue
            // 
            nValue.BackColor = Color.FromArgb(16, 16, 16);
            nValue.BorderStyle = BorderStyle.FixedSingle;
            nValue.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nValue.ForeColor = Color.Silver;
            nValue.Location = new Point(20, 75);
            nValue.Name = "nValue";
            nValue.Size = new Size(387, 33);
            nValue.TabIndex = 1;
            nValue.Text = "Enter value for n";
            nValue.TextAlign = HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.FromArgb(102, 0, 255);
            calculateButton.FlatStyle = FlatStyle.Popup;
            calculateButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            calculateButton.Location = new Point(20, 125);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(387, 37);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // answerValue
            // 
            answerValue.BackColor = Color.FromArgb(16, 16, 16);
            answerValue.BorderStyle = BorderStyle.FixedSingle;
            answerValue.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            answerValue.ForeColor = Color.White;
            answerValue.Location = new Point(146, 188);
            answerValue.Name = "answerValue";
            answerValue.ReadOnly = true;
            answerValue.Size = new Size(261, 33);
            answerValue.TabIndex = 3;
            answerValue.Text = "n!";
            answerValue.TextAlign = HorizontalAlignment.Center;
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            answerLabel.Location = new Point(20, 191);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(120, 25);
            answerLabel.TabIndex = 4;
            answerLabel.Text = "Answer = ";
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(102, 0, 255);
            resetButton.BackgroundImageLayout = ImageLayout.None;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(327, 12);
            resetButton.Margin = new Padding(0);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(80, 31);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 16, 16);
            ClientSize = new Size(433, 273);
            Controls.Add(resetButton);
            Controls.Add(answerLabel);
            Controls.Add(answerValue);
            Controls.Add(calculateButton);
            Controls.Add(nValue);
            Controls.Add(headingLabel);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Factorial Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private TextBox nValue;
        private Button calculateButton;
        private TextBox answerValue;
        private Label answerLabel;
        private Button resetButton;
    }
}