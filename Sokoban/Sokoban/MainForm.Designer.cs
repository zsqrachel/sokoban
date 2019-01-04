/*
 * Created by SharpDevelop.
 * User: win10
 * Date: 2018/12/17
 * Time: 21:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sokoban
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 选关ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 重新开始ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.选关ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.重新开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.选关ToolStripMenuItem,
			this.重新开始ToolStripMenuItem,
			this.帮助ToolStripMenuItem,
			this.关于ToolStripMenuItem,
			this.退出ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(176, 152);
			// 
			// 选关ToolStripMenuItem
			// 
			this.选关ToolStripMenuItem.Name = "选关ToolStripMenuItem";
			this.选关ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
			this.选关ToolStripMenuItem.Text = "选关";
			this.选关ToolStripMenuItem.Click += new System.EventHandler(this.选关ToolStripMenuItemClick);
			// 
			// 重新开始ToolStripMenuItem
			// 
			this.重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem";
			this.重新开始ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
			this.重新开始ToolStripMenuItem.Text = "重新开始";
			this.重新开始ToolStripMenuItem.Click += new System.EventHandler(this.重新开始ToolStripMenuItemClick);
			// 
			// 帮助ToolStripMenuItem
			// 
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
			this.帮助ToolStripMenuItem.Text = "帮助";
			this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItemClick);
			// 
			// 关于ToolStripMenuItem
			// 
			this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
			this.关于ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
			this.关于ToolStripMenuItem.Text = "关于";
			this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItemClick);
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
			this.退出ToolStripMenuItem.Text = "退出";
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(650, 600);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "推箱子";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}

