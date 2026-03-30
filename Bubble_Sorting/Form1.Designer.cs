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
            txtInputArray = new TextBox();
            btnSortAscending = new Button();
            txtResultAscending = new Label();
            SuspendLayout();
            // 
            // txtInputArray
            // 
            txtInputArray.Location = new Point(204, 95);
            txtInputArray.Name = "txtInputArray";
            txtInputArray.Size = new Size(433, 23);
            txtInputArray.TabIndex = 0;
            // 
            // btnSortAscending
            // 
            btnSortAscending.BackColor = Color.ForestGreen;
            btnSortAscending.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSortAscending.Location = new Point(382, 137);
            btnSortAscending.Name = "btnSortAscending";
            btnSortAscending.Size = new Size(75, 29);
            btnSortAscending.TabIndex = 1;
            btnSortAscending.Text = "Sort";
            btnSortAscending.UseVisualStyleBackColor = false;
            btnSortAscending.Click += btnSortAscending_Click;
            // 
            // txtResultAscending
            // 
            txtResultAscending.AutoSize = true;
            txtResultAscending.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultAscending.Location = new Point(204, 58);
            txtResultAscending.Name = "txtResultAscending";
            txtResultAscending.Size = new Size(75, 24);
            txtResultAscending.TabIndex = 2;
            txtResultAscending.Text = "Result:";
            txtResultAscending.Click += txtResultAscending_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultAscending);
            Controls.Add(btnSortAscending);
            Controls.Add(txtInputArray);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputArray;
        private Button btnSortAscending;
        private Label txtResultAscending;
    }
}
