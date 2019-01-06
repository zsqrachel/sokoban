/*
 * Created by SharpDevelop.
 * User: win10
 * Date: 2018/12/17
 * Time: 21:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;

namespace Sokoban.model
{
	/// <summary>
	/// Description of BoxElement.
	/// </summary>
	public class BoxElement:GameElement
	{
		public BoxElement():base(16)
		{
		}
		public override void MoveInForm(System.Windows.Forms.Form winForm,Direction direction,System.ComponentModel.ComponentResourceManager resources)
		{
			GameElement ge = this.Game.GetNeighbor(this,direction);
			if(ge.GetType() == typeof(EmptyElement)){
				this.Game.SwapElement(this,ge);
				ge.Game = this.Game;
			}else if(ge.GetType()==typeof(DestinitionElement)){
				EmptyElement be = new EmptyElement();
				be.Control = this.Control;
				be.Control.BackgroundImage = null;
				be.Game = this.Game;
				this.Game.UpdateMap(be);
				
				BoxInDestinitionElement bid = new BoxInDestinitionElement();
				bid.Control = ge.Control;
				bid.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.sheep.cage")));
				//set this property for each new operaiton
				bid.Game = this.Game;
				this.Game.UpdateMap(bid);
			}
		}
		public override bool CanMove(Direction direction)
		{
			GameElement ge = this.Game.GetNeighbor(this,direction);
			bool pass = true;
			if(ge.GetType()==typeof(WallElement)){
				pass = false;
			}else if(ge.GetType() == typeof(BoxElement)){
				pass = false;
			}else if(ge.GetType() == typeof(BoxInDestinitionElement)){
				pass = false;
			}
			return pass;
		}
	}
}
