/*
 * Created by SharpDevelop.
 * User: win10
 * Date: 2018/12/17
 * Time: 19:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;

namespace Sokoban.model
{
	/// <summary>
	/// Description of EmptyElement.
	/// </summary>
	public class EmptyElement : GameElement
	{
		public EmptyElement():base(2)
		{
		}
		public override void MoveInForm(System.Windows.Forms.Form winForm,Direction direction,System.ComponentModel.ComponentResourceManager resources)
		{
		}
		public override bool CanMove(Direction direction)
		{
			return false;
		}
	}
}
