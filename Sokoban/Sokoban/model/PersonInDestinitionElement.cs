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
	/// Description of PersonInDestinitionElement.
	/// </summary>
	public class PersonInDestinitionElement:GameElement 
	{
		public PersonInDestinitionElement():base(64)
		{
		}
		public override void MoveInForm(System.Windows.Forms.Form winForm,Direction direction,System.ComponentModel.ComponentResourceManager resources)
		{
			bool result = CanMove(direction);
			if(!result) return;
			PictureBox pbx = this.Control;
			Point oldLocation = pbx.Location;
			Point newPoint = Point.Empty;
			Position oldPosition = this.CurrentPosition;
		
		
			GameElement ge = this.Game.GetNeighbor(direction);
			if(ge.GetType()==typeof(EmptyElement)){
				DestinitionElement de = new DestinitionElement();
				de.Control = this.Control;
				de.Control.BackgroundImage =  ((System.Drawing.Image)(resources.GetObject("$this.cage")));
				de.Game = this.Game;
				this.Game.UpdateMap(de);
				
				PersonElement pe = new PersonElement();
				pe.Control = ge.Control;
//				pe.Control.BackgroundImage =  ((System.Drawing.Image)(resources.GetObject("$this.wolf.down")));
				pe.Turn(direction,resources);
				pe.Game = this.Game;
				this.Game.UpdateMap(pe);
			}else if(ge.GetType() == typeof(BoxElement)){
				ge.MoveInForm(winForm,direction,resources);
				ge.Game = this.Game;
				ge = this.Game.GetNeighbor(direction);
				
				DestinitionElement de = new DestinitionElement();
				de.Control = this.Control;
				de.Control.BackgroundImage =  ((System.Drawing.Image)(resources.GetObject("$this.cage")));
				de.Game = this.Game;
				this.Game.UpdateMap(de);
				
				PersonElement pe = new PersonElement();
				pe.Control = ge.Control;
//				pe.Control.BackgroundImage =  ((System.Drawing.Image)(resources.GetObject("$this.wolf.down")));
				pe.Turn(direction,resources);
				pe.Game = this.Game;
				this.Game.UpdateMap(pe);
					
			}else if(ge.GetType() == typeof(DestinitionElement)){
				
				this.Game.SwapElement(this,ge);
				ge.Game = this.Game;
				Turn(direction,resources);
//				DestinitionElement de = new DestinitionElement();
//				de.Control = this.Control;
//				de.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("this.cage")));
//				de.Game = this.Game;
//				this.Game.UpdateMap(de);
//				
//				PersonInDestinitionElement pe = new PersonInDestinitionElement();
//				pe.Control = ge.Control;
//				pe.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("this.wolf.down")));
//				pe.Game = this.Game;
//				this.Game.UpdateMap(pe);
			}else if(ge.GetType() == typeof(BoxInDestinitionElement)){
				result = ge.CanMove(direction);
				if(!result) return;
				ge.MoveInForm(winForm,direction,resources);
				ge = this.Game.GetNeighbor(direction);
				ge.Game = this.Game;
				this.Game.UpdateMap(ge);
				
				this.Game.SwapElement(this,ge);
				ge.Game = this.Game;
					
//				DestinitionElement de = new DestinitionElement();
//				de.Control = this.Control;
//				de.Control.BackgroundImage = null;
//				de.Game = this.Game;
//				this.Game.UpdateMap(de);
//				
//				PersonInDestinitionElement pe = new PersonInDestinitionElement();
//				pe.Control = ge.Control;
//				pe.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.cage.down")));
//				pe.Game = this.Game;
//				this.Game.UpdateMap(pe);
			}
			
			this.Control.BringToFront();
		}
		public override bool CanMove(Direction direction)
		{
			bool pass = true;
			switch(direction){
				case Direction.UP:
					pass = !(this.CurrentPosition.Row<0);
					break;
				case Direction.DOWN:
					pass = !(this.CurrentPosition.Row>10);
					break;
				case Direction.LEFT:
					pass = !(this.CurrentPosition.column<0);
					break;
				case Direction.RIGHT:
					pass = !(this.CurrentPosition.column>14);
					break;
			}
			GameElement ge = this.Game.GetNeighbor(direction);
			if(ge.GetType() == typeof(WallElement)){
			   pass = false;
			}else if(ge.GetType() == typeof(BoxElement)){
				pass = ge.CanMove(direction);
			}else if(ge.GetType() ==typeof(BoxInDestinitionElement)){
				pass = ge.CanMove(direction);
			}
			return pass;
		}
		public void Turn(Direction direction,System.ComponentModel.ComponentResourceManager resources){
			switch(direction){
				case Direction.LEFT:
					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.cage.left")));
					break;
				case Direction.RIGHT:
					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.cage.right")));
					break;
				case Direction.UP:
					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.cage.up")));
					break;
				case Direction.DOWN:
					this.Control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.wolf.cage.down")));
					break;

			}	
		}
	}
}
