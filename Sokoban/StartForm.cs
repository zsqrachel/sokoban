/*
 * Created by SharpDevelop.
 * User: zsq
 * Date: 2018/12/24
 * Time: 14:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sokoban
{
	/// <summary>
	/// Description of StartForm.
	/// </summary>
	public partial class StartForm : Form
	{
		public StartForm()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		public void BtnStartClick(object sender, EventArgs e)
		{
			//this.Close();
			MainForm main = new MainForm();
			main.Show();
//			this.Hide();

		}
		
		void BtnExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnHelpClick(object sender, EventArgs e)
		{
			Sokoban.UI.HelpForm help = new Sokoban.UI.HelpForm();
			help.Show();
		}
	}
}
