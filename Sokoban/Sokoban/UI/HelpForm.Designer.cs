/*
 * Created by SharpDevelop.
 * User: zsq
 * Date: 2018/12/25
 * Time: 8:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sokoban.UI
{
	partial class HelpForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
			this.pbxNothing = new System.Windows.Forms.PictureBox();
			this.pbxBoxInCage = new System.Windows.Forms.PictureBox();
			this.pbxEmpty = new System.Windows.Forms.PictureBox();
			this.pbxWall = new System.Windows.Forms.PictureBox();
			this.pbxBox = new System.Windows.Forms.PictureBox();
			this.lblPic = new System.Windows.Forms.Label();
			this.lblSheep = new System.Windows.Forms.Label();
			this.lblNothing = new System.Windows.Forms.Label();
			this.lblWall = new System.Windows.Forms.Label();
			this.lblSheepInCage = new System.Windows.Forms.Label();
			this.lblEmpty = new System.Windows.Forms.Label();
			this.lblCage = new System.Windows.Forms.Label();
			this.pbxCage = new System.Windows.Forms.PictureBox();
			this.lblAttention = new System.Windows.Forms.Label();
			this.lblMethod = new System.Windows.Forms.Label();
			this.lblDestinition = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblHint = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbxNothing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBoxInCage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxEmpty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxWall)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCage)).BeginInit();
			this.SuspendLayout();
			// 
			// pbxNothing
			// 
			this.pbxNothing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pbxNothing.Location = new System.Drawing.Point(282, 334);
			this.pbxNothing.Margin = new System.Windows.Forms.Padding(2);
			this.pbxNothing.Name = "pbxNothing";
			this.pbxNothing.Size = new System.Drawing.Size(50, 50);
			this.pbxNothing.TabIndex = 0;
			this.pbxNothing.TabStop = false;
			// 
			// pbxBoxInCage
			// 
			this.pbxBoxInCage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxBoxInCage.BackgroundImage")));
			this.pbxBoxInCage.Location = new System.Drawing.Point(518, 398);
			this.pbxBoxInCage.Margin = new System.Windows.Forms.Padding(2);
			this.pbxBoxInCage.Name = "pbxBoxInCage";
			this.pbxBoxInCage.Size = new System.Drawing.Size(50, 50);
			this.pbxBoxInCage.TabIndex = 2;
			this.pbxBoxInCage.TabStop = false;
			// 
			// pbxEmpty
			// 
			this.pbxEmpty.Location = new System.Drawing.Point(518, 334);
			this.pbxEmpty.Margin = new System.Windows.Forms.Padding(2);
			this.pbxEmpty.Name = "pbxEmpty";
			this.pbxEmpty.Size = new System.Drawing.Size(50, 50);
			this.pbxEmpty.TabIndex = 3;
			this.pbxEmpty.TabStop = false;
			// 
			// pbxWall
			// 
			this.pbxWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxWall.BackgroundImage")));
			this.pbxWall.Location = new System.Drawing.Point(282, 463);
			this.pbxWall.Margin = new System.Windows.Forms.Padding(2);
			this.pbxWall.Name = "pbxWall";
			this.pbxWall.Size = new System.Drawing.Size(50, 50);
			this.pbxWall.TabIndex = 4;
			this.pbxWall.TabStop = false;
			// 
			// pbxBox
			// 
			this.pbxBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxBox.BackgroundImage")));
			this.pbxBox.Location = new System.Drawing.Point(282, 398);
			this.pbxBox.Margin = new System.Windows.Forms.Padding(2);
			this.pbxBox.Name = "pbxBox";
			this.pbxBox.Size = new System.Drawing.Size(50, 50);
			this.pbxBox.TabIndex = 5;
			this.pbxBox.TabStop = false;
			// 
			// lblPic
			// 
			this.lblPic.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblPic.Location = new System.Drawing.Point(197, 289);
			this.lblPic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPic.Name = "lblPic";
			this.lblPic.Size = new System.Drawing.Size(127, 43);
			this.lblPic.TabIndex = 6;
			this.lblPic.Text = "图例:";
			// 
			// lblSheep
			// 
			this.lblSheep.Location = new System.Drawing.Point(365, 414);
			this.lblSheep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSheep.Name = "lblSheep";
			this.lblSheep.Size = new System.Drawing.Size(80, 36);
			this.lblSheep.TabIndex = 7;
			this.lblSheep.Text = "箱子";
			// 
			// lblNothing
			// 
			this.lblNothing.Location = new System.Drawing.Point(365, 349);
			this.lblNothing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNothing.Name = "lblNothing";
			this.lblNothing.Size = new System.Drawing.Size(116, 35);
			this.lblNothing.TabIndex = 8;
			this.lblNothing.Text = "墙的外面";
			// 
			// lblWall
			// 
			this.lblWall.Location = new System.Drawing.Point(365, 477);
			this.lblWall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblWall.Name = "lblWall";
			this.lblWall.Size = new System.Drawing.Size(80, 36);
			this.lblWall.TabIndex = 9;
			this.lblWall.Text = "墙";
			// 
			// lblSheepInCage
			// 
			this.lblSheepInCage.Location = new System.Drawing.Point(601, 414);
			this.lblSheepInCage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSheepInCage.Name = "lblSheepInCage";
			this.lblSheepInCage.Size = new System.Drawing.Size(257, 36);
			this.lblSheepInCage.TabIndex = 10;
			this.lblSheepInCage.Text = "箱子放到正确位置后";
			// 
			// lblEmpty
			// 
			this.lblEmpty.Location = new System.Drawing.Point(601, 349);
			this.lblEmpty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblEmpty.Name = "lblEmpty";
			this.lblEmpty.Size = new System.Drawing.Size(80, 35);
			this.lblEmpty.TabIndex = 11;
			this.lblEmpty.Text = "地板";
			// 
			// lblCage
			// 
			this.lblCage.Location = new System.Drawing.Point(601, 477);
			this.lblCage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCage.Name = "lblCage";
			this.lblCage.Size = new System.Drawing.Size(257, 36);
			this.lblCage.TabIndex = 12;
			this.lblCage.Text = "放箱子的位置";
			// 
			// pbxCage
			// 
			this.pbxCage.BackColor = System.Drawing.SystemColors.Control;
			this.pbxCage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxCage.BackgroundImage")));
			this.pbxCage.Location = new System.Drawing.Point(518, 463);
			this.pbxCage.Margin = new System.Windows.Forms.Padding(2);
			this.pbxCage.Name = "pbxCage";
			this.pbxCage.Size = new System.Drawing.Size(50, 50);
			this.pbxCage.TabIndex = 13;
			this.pbxCage.TabStop = false;
			// 
			// lblAttention
			// 
			this.lblAttention.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblAttention.Location = new System.Drawing.Point(197, 564);
			this.lblAttention.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAttention.Name = "lblAttention";
			this.lblAttention.Size = new System.Drawing.Size(137, 38);
			this.lblAttention.TabIndex = 14;
			this.lblAttention.Text = "注意:";
			// 
			// lblMethod
			// 
			this.lblMethod.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblMethod.Location = new System.Drawing.Point(197, 209);
			this.lblMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMethod.Name = "lblMethod";
			this.lblMethod.Size = new System.Drawing.Size(104, 42);
			this.lblMethod.TabIndex = 15;
			this.lblMethod.Text = "玩法:";
			// 
			// lblDestinition
			// 
			this.lblDestinition.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblDestinition.Location = new System.Drawing.Point(197, 133);
			this.lblDestinition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDestinition.Name = "lblDestinition";
			this.lblDestinition.Size = new System.Drawing.Size(118, 34);
			this.lblDestinition.TabIndex = 16;
			this.lblDestinition.Text = "目标:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(334, 213);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(370, 62);
			this.label4.TabIndex = 17;
			this.label4.Text = "用箭头键推动箱子到正确的位置。";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(334, 139);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(370, 41);
			this.label5.TabIndex = 18;
			this.label5.Text = "将所有的箱子推到标记的位置。";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(329, 564);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(529, 79);
			this.label6.TabIndex = 19;
			this.label6.Text = "(1)一旦箱子被移动到角落，则游戏无法完成。\r\n\r\n(2)玩家不可同时推动两个或以上的箱子。";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(334, 45);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(327, 53);
			this.label7.TabIndex = 20;
			this.label7.Text = "推箱子游戏说明";
			// 
			// lblHint
			// 
			this.lblHint.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblHint.Location = new System.Drawing.Point(197, 671);
			this.lblHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHint.Name = "lblHint";
			this.lblHint.Size = new System.Drawing.Size(109, 48);
			this.lblHint.TabIndex = 21;
			this.lblHint.Text = "提示:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(329, 675);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(400, 52);
			this.label9.TabIndex = 22;
			this.label9.Text = "可以通过右键单击窗口打开工具栏。";
			// 
			// HelpForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(997, 800);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lblHint);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblDestinition);
			this.Controls.Add(this.lblMethod);
			this.Controls.Add(this.lblAttention);
			this.Controls.Add(this.pbxCage);
			this.Controls.Add(this.lblCage);
			this.Controls.Add(this.lblEmpty);
			this.Controls.Add(this.lblSheepInCage);
			this.Controls.Add(this.lblWall);
			this.Controls.Add(this.lblNothing);
			this.Controls.Add(this.lblSheep);
			this.Controls.Add(this.lblPic);
			this.Controls.Add(this.pbxBox);
			this.Controls.Add(this.pbxWall);
			this.Controls.Add(this.pbxEmpty);
			this.Controls.Add(this.pbxBoxInCage);
			this.Controls.Add(this.pbxNothing);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "HelpForm";
			this.Text = "help";
			((System.ComponentModel.ISupportInitialize)(this.pbxNothing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBoxInCage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxEmpty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxWall)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCage)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblDestinition;
		private System.Windows.Forms.Label lblMethod;
		private System.Windows.Forms.Label lblAttention;
		private System.Windows.Forms.PictureBox pbxCage;
		private System.Windows.Forms.Label lblCage;
		private System.Windows.Forms.Label lblEmpty;
		private System.Windows.Forms.Label lblSheepInCage;
		private System.Windows.Forms.Label lblWall;
		private System.Windows.Forms.Label lblNothing;
		private System.Windows.Forms.Label lblSheep;
		private System.Windows.Forms.Label lblPic;
		private System.Windows.Forms.PictureBox pbxBox;
		private System.Windows.Forms.PictureBox pbxWall;
		private System.Windows.Forms.PictureBox pbxEmpty;
		private System.Windows.Forms.PictureBox pbxBoxInCage;
		private System.Windows.Forms.PictureBox pbxNothing;
		private System.Windows.Forms.Label lblHint;
		private System.Windows.Forms.Label label9;
	}
}
