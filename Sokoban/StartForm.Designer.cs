/*
 * Created by SharpDevelop.
 * User: zsq
 * Date: 2018/12/24
 * Time: 14:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sokoban
{
	partial class StartForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
			this.pbxTitle = new System.Windows.Forms.PictureBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.BtnHelp = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// pbxTitle
			// 
			this.pbxTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxTitle.BackgroundImage")));
			this.pbxTitle.Location = new System.Drawing.Point(137, 36);
			this.pbxTitle.Margin = new System.Windows.Forms.Padding(2);
			this.pbxTitle.Name = "pbxTitle";
			this.pbxTitle.Size = new System.Drawing.Size(337, 145);
			this.pbxTitle.TabIndex = 0;
			this.pbxTitle.TabStop = false;
			// 
			// btnStart
			// 
			this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
			this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.Location = new System.Drawing.Point(259, 270);
			this.btnStart.Margin = new System.Windows.Forms.Padding(2);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(120, 48);
			this.btnStart.TabIndex = 1;
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
			// 
			// btnExit
			// 
			this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Location = new System.Drawing.Point(259, 333);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(120, 48);
			this.btnExit.TabIndex = 2;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// BtnHelp
			// 
			this.BtnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHelp.BackgroundImage")));
			this.BtnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnHelp.Location = new System.Drawing.Point(259, 396);
			this.BtnHelp.Margin = new System.Windows.Forms.Padding(2);
			this.BtnHelp.Name = "BtnHelp";
			this.BtnHelp.Size = new System.Drawing.Size(120, 48);
			this.BtnHelp.TabIndex = 3;
			this.BtnHelp.UseVisualStyleBackColor = true;
			this.BtnHelp.Click += new System.EventHandler(this.BtnHelpClick);
			// 
			// StartForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(629, 540);
			this.Controls.Add(this.BtnHelp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.pbxTitle);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "StartForm";
			this.Text = "推箱子";
			((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button BtnHelp;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.PictureBox pbxTitle;
	}
}
