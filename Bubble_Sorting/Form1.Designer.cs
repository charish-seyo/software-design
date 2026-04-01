namespace Bubble_Sorting
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
            btnSort = new Button();
            lblInput = new Label();
            lblOutput = new Label();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(57, 95);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(199, 23);
            txtInput.TabIndex = 0;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.ForestGreen;
            btnSort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(57, 133);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 29);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSortAscending_Click;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInput.Location = new Point(57, 57);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(167, 24);
            lblInput.TabIndex = 2;
            lblInput.Text = "Enter numbers:";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(57, 176);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(154, 24);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "Sorted Result:";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(57, 215);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(199, 23);
            txtOutput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(634, 413);
            Controls.Add(txtOutput);
            Controls.Add(lblOutput);
            Controls.Add(lblInput);
            Controls.Add(btnSort);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnSort;
        private Label lblInput;
        private Label lblOutput;
        private TextBox txtOutput;
    }
}
