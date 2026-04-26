namespace lab3
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
            lstBookInfo = new ListBox();
            btnShowInfo = new Button();
            SuspendLayout();
            // 
            // lstBookInfo
            // 
            lstBookInfo.FormattingEnabled = true;
            lstBookInfo.ItemHeight = 15;
            lstBookInfo.Location = new Point(23, 54);
            lstBookInfo.Name = "lstBookInfo";
            lstBookInfo.Size = new Size(296, 274);
            lstBookInfo.TabIndex = 0;
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(23, 25);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(75, 23);
            btnShowInfo.TabIndex = 1;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 412);
            Controls.Add(btnShowInfo);
            Controls.Add(lstBookInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstBookInfo;
        private Button btnShowInfo;
    }
}
