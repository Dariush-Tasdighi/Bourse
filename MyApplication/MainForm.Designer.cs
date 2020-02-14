namespace MyApplication
{
	partial class MainForm
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
			this.downloadFileButton = new System.Windows.Forms.Button();
			this.contentTextBox = new System.Windows.Forms.TextBox();
			this.myDataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// downloadFileButton
			// 
			this.downloadFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.downloadFileButton.Location = new System.Drawing.Point(12, 15);
			this.downloadFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.downloadFileButton.Name = "downloadFileButton";
			this.downloadFileButton.Size = new System.Drawing.Size(471, 28);
			this.downloadFileButton.TabIndex = 0;
			this.downloadFileButton.Text = "دانلود فایل اطلاعات";
			this.downloadFileButton.UseVisualStyleBackColor = true;
			this.downloadFileButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// contentTextBox
			// 
			this.contentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contentTextBox.Location = new System.Drawing.Point(12, 276);
			this.contentTextBox.Multiline = true;
			this.contentTextBox.Name = "contentTextBox";
			this.contentTextBox.Size = new System.Drawing.Size(471, 78);
			this.contentTextBox.TabIndex = 2;
			// 
			// myDataGridView
			// 
			this.myDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myDataGridView.Location = new System.Drawing.Point(12, 50);
			this.myDataGridView.Name = "myDataGridView";
			this.myDataGridView.RowHeadersWidth = 62;
			this.myDataGridView.Size = new System.Drawing.Size(471, 220);
			this.myDataGridView.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 366);
			this.Controls.Add(this.myDataGridView);
			this.Controls.Add(this.contentTextBox);
			this.Controls.Add(this.downloadFileButton);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button downloadFileButton;
		private System.Windows.Forms.TextBox contentTextBox;
		private System.Windows.Forms.DataGridView myDataGridView;
	}
}
