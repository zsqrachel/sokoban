/*
 * Created by SharpDevelop.
 * User: win10
 * Date: 2018/12/17
 * Time: 14:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sokoban
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			sf = new StartForm();
			Application.Run(sf);
//			Application.Run(new Sokoban.UI.SelectForm());
			
		}
		public static StartForm sf;
	}
			
}