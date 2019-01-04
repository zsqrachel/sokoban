/*
 * Created by SharpDevelop.
 * User: win10
 * Date: 2018/12/17
 * Time: 15:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;

namespace Sokoban.model
{
	/// <summary>
	/// Description of DestinitionElement.
	/// </summary>
	public class DestinitionElement : GameElement
	{
		public DestinitionElement():base(1)
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
