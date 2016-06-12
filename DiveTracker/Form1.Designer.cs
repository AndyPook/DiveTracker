namespace DiveTracker
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnPoint = new System.Windows.Forms.Button();
			this.lbPoints = new System.Windows.Forms.ListBox();
			this.txtSequence = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
			this.SuspendLayout();
			// 
			// wmp
			// 
			this.wmp.Dock = System.Windows.Forms.DockStyle.Left;
			this.wmp.Enabled = true;
			this.wmp.Location = new System.Drawing.Point(0, 0);
			this.wmp.Name = "wmp";
			this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
			this.wmp.Size = new System.Drawing.Size(395, 396);
			this.wmp.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(446, 46);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
			// 
			// btnPoint
			// 
			this.btnPoint.Location = new System.Drawing.Point(552, 10);
			this.btnPoint.Name = "btnPoint";
			this.btnPoint.Size = new System.Drawing.Size(75, 23);
			this.btnPoint.TabIndex = 2;
			this.btnPoint.Text = "Exit";
			this.btnPoint.UseVisualStyleBackColor = true;
			this.btnPoint.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbPoints
			// 
			this.lbPoints.FormattingEnabled = true;
			this.lbPoints.Location = new System.Drawing.Point(446, 73);
			this.lbPoints.Name = "lbPoints";
			this.lbPoints.Size = new System.Drawing.Size(120, 277);
			this.lbPoints.TabIndex = 3;
			this.lbPoints.Click += new System.EventHandler(this.listBox1_Click);
			// 
			// txtSequence
			// 
			this.txtSequence.Location = new System.Drawing.Point(446, 12);
			this.txtSequence.Name = "txtSequence";
			this.txtSequence.Size = new System.Drawing.Size(100, 20);
			this.txtSequence.TabIndex = 4;
			this.txtSequence.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSequence_KeyUp);
			this.txtSequence.Leave += new System.EventHandler(this.txtSequence_Leave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 396);
			this.Controls.Add(this.txtSequence);
			this.Controls.Add(this.lbPoints);
			this.Controls.Add(this.btnPoint);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.wmp);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer wmp;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnPoint;
		private System.Windows.Forms.ListBox lbPoints;
		private System.Windows.Forms.TextBox txtSequence;
	}
}

