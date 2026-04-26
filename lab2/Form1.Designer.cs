namespace lab2
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
            txtInput = new TextBox();
            lblResult = new Label();
            btnCalculateFactorial = new Button();
            txtArrayInput = new TextBox();
            lblSumResult = new Label();
            btnCalculateSum = new Button();
            txtFibonacciInput = new TextBox();
            btnCalculateFibonacci = new Button();
            lblFibonacciResult = new Label();
            txtBaseInput = new TextBox();
            btnCalculatePower = new Button();
            lblPowerResult = new Label();
            txtExponentInput = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(52, 53);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(148, 23);
            txtInput.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(52, 35);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result:";
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(52, 82);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(75, 23);
            btnCalculateFactorial.TabIndex = 3;
            btnCalculateFactorial.Text = "Calculate";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(261, 53);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(130, 23);
            txtArrayInput.TabIndex = 4;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(265, 31);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(31, 15);
            lblSumResult.TabIndex = 5;
            lblSumResult.Text = "Sum";
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(261, 82);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(100, 23);
            btnCalculateSum.TabIndex = 6;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(52, 190);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(148, 23);
            txtFibonacciInput.TabIndex = 7;
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(52, 228);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(75, 23);
            btnCalculateFibonacci.TabIndex = 8;
            btnCalculateFibonacci.Text = "Calculate";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(52, 172);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(42, 15);
            lblFibonacciResult.TabIndex = 9;
            lblFibonacciResult.Text = "Result:";
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(261, 190);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(148, 23);
            txtBaseInput.TabIndex = 10;
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(261, 261);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(75, 23);
            btnCalculatePower.TabIndex = 11;
            btnCalculatePower.Text = "Calculate";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(265, 172);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(42, 15);
            lblPowerResult.TabIndex = 12;
            lblPowerResult.Text = "Result:";
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(261, 232);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(148, 23);
            txtExponentInput.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 525);
            Controls.Add(txtExponentInput);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalculatePower);
            Controls.Add(txtBaseInput);
            Controls.Add(lblFibonacciResult);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(txtFibonacciInput);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label lblResult;
        private Button btnCalculateFactorial;
        private TextBox txtArrayInput;
        private Label lblSumResult;
        private Button btnCalculateSum;
        private TextBox txtFibonacciInput;
        private Button btnCalculateFibonacci;
        private Label lblFibonacciResult;
        private TextBox txtBaseInput;
        private Button btnCalculatePower;
        private Label lblPowerResult;
        private TextBox txtExponentInput;
    }
}
