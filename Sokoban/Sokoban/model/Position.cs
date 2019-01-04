/*
 * Created by SharpDevelop.
 * User: win10
 * Date: 2018/12/17
 * Time: 17:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Sokoban.model
{
	/// <summary>
	/// Description of Position.
	/// </summary>
	public class Position
	{
		public int Row{get;set;}
			
			
		public int column{get;set;}
		public Position()
		{	
		}
		public Position(int row, int column)
		{
			this.Row = row;
			this.column = column;
		}
	}
}
