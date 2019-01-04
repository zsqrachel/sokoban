/*
 * Created by SharpDevelop.
 * User: zsq
 * Date: 2018/12/26
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sokoban.UI
{
	/// <summary>
	/// Description of AboutForm.
	/// </summary>
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
	}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
