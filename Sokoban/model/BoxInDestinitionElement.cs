/*
 * Created by SharpDevelop.
 * User: win10
 * Date: 2018/12/17
 * Time: 21:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sokoban.model
{
	/// <summary>
	/// Description of BoxInDestinitionElement.
	/// </summary>
	public class BoxInDestinitionElement:GameElement 
	{
		public BoxInDestinitionElement():base(32)
		{
		}
		public override void MoveInForm(System.Windows.Forms.Form winForm,Direction direction,System.ComponentModel.ComponentResourceManager resources)
		{
			bool result = CanMove(direction);
			if(!result) return;
			GameElement ge = this.Game.GetNeighbor(this,direction);
			if(ge.GetType() == typeof(EmptyElement)){
				DestinitionElement de = new DestinitionElement();
				de.Control = this.Control;
				de.Control.BackgroundImage =  ((System.Drawing.Image)(resources.GetObject("$this.cage")));
				de.Game = this.Game;
				this.Game.UpdateMap(de);
				
				BoxElement be = new BoxElement();
				be.Control = ge.Control;
				be.Control.BackgroundImage =  ((System.Drawing.Image)(resources.GetObject("$this.sheep")));
				be.Game = this.Game;
				this.Game.UpdateMap(be);
			}else if(ge.GetType()==typeof(DestinitionElement)){
				
//				DestinitionElement de = new DestinitionElement();
//				de.Control = this.Control;
//				de.Control.BackgroundImage =  ((System.Drawing.Image)(resources.GetObject("$this.cage")));
//				de.Game = this.Game;
//				this.Game.UpdateMap(de);
//				
//				BoxInDestinitionElement be = new BoxInDestinitionElement();
//				be.Control = ge.Control;
//				be.Control.BackgroundImage =  ((System.Drawing.Image)(resources.GetObject("$this.sheep.cage")));
//				de.Game = this.Game;
//				this.Game.UpdateMap(be);
				
				this.Game.SwapElement(this,ge);
				ge.Game = this.Game;
			}
		}
		public override bool CanMove(Direction direction)
		{
			GameElement ge = this.Game.GetNeighbor(this,direction);
			if(ge.GetType()==typeof(WallElement)){
				return false;
			}else if(ge.GetType() == typeof(BoxElement)){
				return false;
			}else if(ge.GetType() == typeof(BoxInDestinitionElement)){
				return false;
			}
			return true;
		}
	}
}
