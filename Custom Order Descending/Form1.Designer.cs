namespace Custom_Order_Descending
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
            lblInput = new Label();
            txtOutput = new TextBox();
            btnSortDesc = new Button();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInput.Location = new Point(85, 58);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(148, 30);
            lblInput.TabIndex = 0;
            lblInput.Text = "Enter numbers";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(85, 151);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(173, 23);
            txtOutput.TabIndex = 1;
            // 
            // btnSortDesc
            // 
            btnSortDesc.BackColor = Color.ForestGreen;
            btnSortDesc.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSortDesc.ForeColor = SystemColors.ButtonHighlight;
            btnSortDesc.Location = new Point(85, 120);
            btnSortDesc.Name = "btnSortDesc";
            btnSortDesc.Size = new Size(123, 25);
            btnSortDesc.TabIndex = 2;
            btnSortDesc.Text = "Sort Descending";
            btnSortDesc.UseVisualStyleBackColor = false;
            btnSortDesc.Click += btnSortDesc_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(85, 91);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(173, 23);
            txtInput.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(613, 376);
            Controls.Add(txtInput);
            Controls.Add(btnSortDesc);
            Controls.Add(txtOutput);
            Controls.Add(lblInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtOutput;
        private Button btnSortDesc;
        private TextBox txtInput;
    }
}
