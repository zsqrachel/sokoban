/*
 * Created by SharpDevelop.
 * User: win10
 * Date: 2018/12/17
 * Time: 15:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using Sokoban.model;

namespace Sokoban.model
{
	/// <summary>
	/// Description of GameElement.
	/// </summary>
	public abstract class GameElement
	{
		private int _type;
		
		public int Type{get{return this._type;}}
		
		public PictureBox Control{get;set;}
		
		public Position CurrentPosition{get{
				int x = this.Control.Location.X;
				int y = this.Control.Location.Y;
				return new Position(y/50,x/50);
			}
		}
		
		public GameElement(int type)
		{
			this._type = type;
		}
		
		public void ShowInForm(Form winForm){
			PictureBox pbx = this.Control;
			winForm.Controls.Add(pbx);
		}
		
		
		public abstract void MoveInForm(Form winForm,Direction direction,System.ComponentModel.ComponentResourceManager resources);
		
		public abstract bool CanMove(Direction direction);
		
		public Game Game{get;set;}
	}
}
